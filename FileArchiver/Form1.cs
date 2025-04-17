using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileArchiver
{
    public partial class Form1 : Form
    {
        private string[] CommonTypes = new string[]
        {
            ".doc", ".docm", ".docx", ".dot", ".dotm", ".dotx",
            ".xls", ".xlsx", ".xlsm", ".csv", ".xla", ".xlam", ".xlsb", ".xlt", ".xltm",
            ".ppt", ".pptx", ".pot", ".potm", ".ppa", ".ppam", ".pps", ".ppsm", ".ppsx",
            ".pub", ".vsd", ".vsdx", ".vdwm", ".dia", ".drawio", ".ai",
            ".mpp", ".mpx", ".mspdi",
            ".odt", ".fodt", ".ods", ".fods", ".odp", ".fodp", ".odg", ".fodg", ".odf", ".sda", ".sdb", ".sdc", ".sdd",
            ".rtf", ".txt", ".htm", ".html", ".wps", ".mht", ".mhtml", ".xml", ".prn", ".slk", ".xaml", ".js", ".css",
            ".xps", ".oxps", ".pdf",
            ".bmp", ".emf",".gif",".jpg",".jpeg",".png",".tif",".tiff",".tga",".eps",".webp",".svg", ".xcf", ".psd",
            ".epub", ".mobi",
            ".eml", ".msg"
        };
        public Form1()
        {
            InitializeComponent();
            cmbDateAttribute.SelectedIndex = 2;
            cmbDateDirection.SelectedIndex = 0;
            dtpDateFilterStart.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + " " + CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern;
            dtpDateFilterStart.Value = DateTime.Now.Date;
            dtpDateFilterEnd.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + " " + CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern;
            dtpDateFilterEnd.Value = DateTime.Now.Date;
            cmbSizeMode.SelectedIndex = 0;
            nudSizeStart.Maximum = Decimal.MaxValue;
            nudSizeStart.Minimum = 0;
            cmbSizeStartUnit.SelectedIndex = 0;
            nudSizeEnd.Maximum = Decimal.MaxValue;
            nudSizeEnd.Value = 1;
            cmbSizeEndUnit.SelectedIndex = 3;
            cmbActionType.SelectedIndex = 0;
            cmbFilterArchived.SelectedIndex = 1;
            cmbFilterHidden.SelectedIndex = 0;
            cmbFilterReadonly.SelectedIndex = 1;
            cmbFilterSystem.SelectedIndex = 0;
            cmbActionArchived.SelectedIndex = 1;
            cmbActionHidden.SelectedIndex = 1;
            cmbActionReadonly.SelectedIndex = 1;
            cmbActionSystem.SelectedIndex = 1;
        }
        
        private void cmdScanSource_Click(object sender, EventArgs e)
        {
            DirIndex.Clear();
            DirList.Clear();
            FileList.Clear();
            GC.Collect();
            bool ignoreerrors = false;
            bool abort = false;
            WalkDirectory(txtSourceDirectory.Text, null, ref ignoreerrors, ref abort);
            if (abort)
            {
                DirIndex.Clear();
                DirList.Clear();
                FileList.Clear();
                GC.Collect();
            }
            HashSet<string> Extensions = new HashSet<string>();
            foreach (var item in FileList)
            {
                if (!Extensions.Contains(item.Extension))
                {
                    Extensions.Add(item.Extension);
                }
            }
            chklstFileTypes.Items.Clear();
            foreach (var item in Extensions)
            {
                chklstFileTypes.Items.Add(item);
            }
            UpdateFilterSelection();
            if (abort)
            {
                txtPreviewFilters.Text = "Directory scan aborted.";
            }
            else
            {
                txtPreviewFilters.Text = "Directory scan completed. Click [Preview filter results] above to show file filter results.";
            }
        }

        public Dictionary<string, DirItem> DirIndex = new Dictionary<string, DirItem>();
        public List<DirItem> DirList = new List<DirItem>();
        public List<FileItem> FileList = new List<FileItem>();

        public class FileItem
        {
            public string FileName;
            public string Extension;
            public DirItem Parent;
            public long Size = 0;
            public DateTime CreationDate;
            public DateTime ModifiedDate;
            public DateTime LastAccessedDate;
            public bool Selected = false;
            public bool Hidden = false;
            public bool Readonly = false;
            public bool Archive = false;
            public bool System = false;
        }

        public class DirItem
        {
            public string PartialPath;
            public string AbsolutePath;
            public DirItem Parent;
            public List<DirItem> ChildDirs = new List<DirItem>();
            public List<FileItem> ChildFiles = new List<FileItem>();
        }

        private void WalkDirectory(string path, DirItem parent, ref bool ignoreErrors, ref bool abort)
        {
            try
            {
                if (parent == null)
                {
                    parent = new DirItem()
                    {
                        AbsolutePath = path,
                        Parent = null,
                        ChildDirs = new List<DirItem>(),
                        ChildFiles = new List<FileItem>(),
                        PartialPath = ""
                    };
                    DirList.Add(parent);
                }
                try
                {
                    string[] files = Directory.GetFiles(path);
                    foreach (var file in files)
                    {
                        try
                        {
                            FileInfo finfo = new FileInfo(file);
                            var newFileItem = new FileItem()
                            {
                                Extension = finfo.Extension,
                                Parent = parent,
                                FileName = finfo.Name,
                                Selected = false,
                                Size = finfo.Length,
                                CreationDate = finfo.CreationTime,
                                ModifiedDate = finfo.LastWriteTime,
                                LastAccessedDate = finfo.LastAccessTime,
                                Hidden = finfo.Attributes.HasFlag(FileAttributes.Hidden),
                                Readonly = finfo.Attributes.HasFlag(FileAttributes.ReadOnly),
                                Archive = finfo.Attributes.HasFlag(FileAttributes.Archive),
                                System = finfo.Attributes.HasFlag(FileAttributes.System)
                            };
                            parent.ChildFiles.Add(newFileItem);
                            FileList.Add(newFileItem);
                        }
                        catch (Exception ex)
                        {
                            if (!ignoreErrors)
                            {
                                using (frmErrorDialog dlg = new frmErrorDialog())
                                {
                                    dlg.lblMessage.Text = string.Format("An error occurred scanning the directory.\r\n{0}", ex.Message);
                                    DialogResult res = dlg.ShowDialog();
                                    if (res == DialogResult.Ignore)
                                    {
                                        ignoreErrors = true;
                                    }
                                    else if (res == DialogResult.Abort)
                                    {
                                        abort = true;
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    if (!ignoreErrors)
                    {
                        using (frmErrorDialog dlg = new frmErrorDialog())
                        {
                            dlg.lblMessage.Text = string.Format("An error occurred scanning the directory.\r\n{0}", e.Message);
                            DialogResult res = dlg.ShowDialog();
                            if (res == DialogResult.Ignore)
                            {
                                ignoreErrors = true;
                            }
                            else if (res == DialogResult.Abort)
                            {
                                abort = true;
                                return;
                            }
                        }
                    }
                }
                try
                {
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (var dir in dirs)
                    {
                        DirectoryInfo info = new DirectoryInfo(dir);
                        DirItem newDirItem = new DirItem()
                        {
                            AbsolutePath = dir,
                            ChildDirs = new List<DirItem>(),
                            ChildFiles = new List<FileItem>(),
                            Parent = parent,
                            PartialPath = info.Name
                        };
                        parent.ChildDirs.Add(newDirItem);
                        WalkDirectory(dir, newDirItem, ref ignoreErrors, ref abort);
                        if (abort)
                        {
                            return;
                        }
                    }
                }
                catch (Exception e)
                {
                    if (!ignoreErrors)
                    {
                        using (frmErrorDialog dlg = new frmErrorDialog())
                        {
                            dlg.lblMessage.Text = string.Format("An error occurred scanning the directory.\r\n{0}", e.Message);
                            DialogResult res = dlg.ShowDialog();
                            if (res == DialogResult.Ignore)
                            {
                                ignoreErrors = true;
                            }
                            else if (res == DialogResult.Abort)
                            {
                                abort = true;
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (!ignoreErrors)
                {
                    using (frmErrorDialog dlg = new frmErrorDialog())
                    {
                        dlg.lblMessage.Text = string.Format("An error occurred scanning the directory.\r\n{0}", e.Message);
                        DialogResult res = dlg.ShowDialog();
                        if (res == DialogResult.Ignore)
                        {
                            ignoreErrors = true;
                        }
                        else if (res == DialogResult.Abort)
                        {
                            abort = true;
                            return;
                        }
                    }
                }
            }
        }

        private void UpdateFilterSelection()
        {
            long fileCount = 0;
            long fileSize = 0;
            long selectedCount = 0;
            long selectedSize = 0;
            HashSet<string> FilterExtensions = null;
            if (chkTypeFilter.Checked)
            {
                FilterExtensions = new HashSet<string>();
                foreach (var checkedExt in chklstFileTypes.CheckedItems)
                {
                    string strext = checkedExt.ToString();
                    if (!FilterExtensions.Contains(strext))
                    {
                        FilterExtensions.Add(strext);
                    }
                }
            }
            foreach (var item in FileList)
            {
                fileCount++;
                fileSize += item.Size;
                item.Selected = true;
                
                if (chkDateFilter.Checked)
                {
                    DateTime dt;
                    switch (cmbDateAttribute.SelectedIndex)
                    {
                        case 0:
                            // creation date
                            dt = item.CreationDate;
                            break;
                        case 1:
                            // modified date
                            dt = item.ModifiedDate;
                            break;
                        case 2:
                            // last accessed date
                            dt = item.LastAccessedDate;
                            break;
                        default:
                            return;
                    }
                    
                    switch (cmbDateDirection.SelectedIndex)
                    {
                        case 0:
                            // before
                            if (dt > dtpDateFilterStart.Value)
                            {
                                item.Selected = false;
                            }
                            break;
                        case 1:
                            // after
                            if (dt < dtpDateFilterStart.Value)
                            {
                                item.Selected = false;
                            }
                            break;
                        case 2:
                            // between
                            if (dtpDateFilterStart.Value < dtpDateFilterEnd.Value)
                            {
                                if (dt < dtpDateFilterStart.Value || dt > dtpDateFilterEnd.Value)
                                {
                                    item.Selected = false;
                                }
                            }
                            else
                            {
                                // start and end dates are reversed, so swap the comparators
                                if (dt > dtpDateFilterStart.Value || dt < dtpDateFilterEnd.Value)
                                {
                                    item.Selected = false;
                                }
                            }
                            break;
                    }
                }
                if (chkTypeFilter.Checked)
                {
                    if (!FilterExtensions.Contains(item.Extension))
                    {
                        item.Selected = false;
                    }
                }
                if (chkFileSizeFilter.Checked)
                {
                    switch (cmbSizeMode.SelectedIndex)
                    {
                        case 0:
                            // Larger than
                            if (item.Size < UnitSizeExpand(nudSizeStart.Value, (string)cmbSizeStartUnit.Text))
                            {
                                item.Selected = false;
                            }
                            break;
                        case 1:
                            //Smaller than
                            if (item.Size >= UnitSizeExpand(nudSizeStart.Value, (string)cmbSizeStartUnit.Text))
                            {
                                item.Selected = false;
                            }
                            break;
                        case 2:
                            //Between
                            if (UnitSizeExpand(nudSizeStart.Value, (string)cmbSizeStartUnit.Text) < UnitSizeExpand(nudSizeEnd.Value, (string)cmbSizeEndUnit.Text))
                            {
                                if (item.Size < UnitSizeExpand(nudSizeStart.Value, (string)cmbSizeStartUnit.Text) || 
                                    item.Size > UnitSizeExpand(nudSizeEnd.Value, (string)cmbSizeEndUnit.Text))
                                {
                                    item.Selected = false;
                                }
                            }
                            else
                            {
                                // range values are reversed.
                                if (item.Size > UnitSizeExpand(nudSizeStart.Value, (string)cmbSizeStartUnit.Text) || 
                                    item.Size < UnitSizeExpand(nudSizeEnd.Value, (string)cmbSizeEndUnit.Text))
                                {
                                    item.Selected = false;
                                }
                            }
                            break;
                    }
                }
                if (chkAttributeFilter.Checked)
                {
                    if (chkFilterReadonly.Checked)
                    {
                        bool val = cmbFilterReadonly.SelectedIndex == 1;
                        if (item.Readonly != val)
                        {
                            item.Selected = false;
                        }
                    }
                    if (chkFilterHidden.Checked)
                    {
                        bool val = cmbFilterHidden.SelectedIndex == 1;
                        if (item.Hidden != val)
                        {
                            item.Selected = false;
                        }
                    }
                    if (chkFilterArchived.Checked)
                    {
                        bool val = cmbFilterArchived.SelectedIndex == 1;
                        if (item.Archive != val)
                        {
                            item.Selected = false;
                        }
                    }
                    if (chkFilterSystem.Checked)
                    {
                        bool val = cmbFilterSystem.SelectedIndex == 1;
                        if (item.System != val)
                        {
                            item.Selected = false;
                        }
                    }
                }

                if (item.Selected)
                {
                    selectedCount++;
                    selectedSize += item.Size;
                }
            }
            lblTotalFiles.Text = string.Format("Total Files: {0}", fileCount);
            lblTotalFileSize.Text = string.Format("Total File Size: {0}", PrettyFormat(fileSize));
            lblSelectedFiles.Text = string.Format("Selected Files: {0}", selectedCount);
            lblSelectedSize.Text = string.Format("Selected File Size: {0}", PrettyFormat(selectedSize));
        }

        private string PrettyFormat(long size)
        {
            if (Math.Abs(size) >= 1000000000000000000)
            {
                return string.Format("{0:0.00} EiB", size / 1152921504606846976);
            }
            else if (Math.Abs(size) > 1000000000000000)
            {
                return string.Format("{0:0.00} PiB", size / 1125899906842624);
            }
            else if (Math.Abs(size) > 1000000000000)
            {
                return string.Format("{0:0.00} TiB", size / 1099511627776);
            }
            else if (Math.Abs(size) >= 1000000000)
            {
                return string.Format("{0:0.00} GiB", size / 1073741824);
            }
            else if (Math.Abs(size) >= 1000000)
            {
                return string.Format("{0:0.00} MiB", size / 1048576);
            }
            else if (Math.Abs(size) >= 1000)
            {
                return string.Format("{0:0.00} KiB", size / 1024);
            }
            else
            {
                return string.Format("{0} bytes", size);
            }
        }

        private long UnitSizeExpand(decimal value, string unit)
        {
            switch (unit)
            {
                case "Bytes":
                    return (long)value;
                case "KiB":
                    return (long)(value * 1024m);
                case "MiB":
                    return (long)(value * 1048576m);
                case "GiB":
                    return (long)(value * 1073741824m);
                case "TiB":
                    return (long)(value * 1099511627776m);
                case "PiB":
                    return (long)(value * 1125899906842624m);
                case "EiB":
                    return (long)(value * 1152921504606846976m);
                default:
                    MessageBox.Show(string.Format("Unknown Unit suffix {0}", unit));
                    return 0;
            }
        }

        private void UpdateDisplay()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in FileList.Where(x => x.Selected))
            {
                sb.AppendLine(Path.Combine(item.Parent.AbsolutePath, item.FileName));
            }
            txtPreviewFilters.Clear();
            txtPreviewFilters.Text = sb.ToString();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            cmbDateAttribute.Enabled = chkDateFilter.Checked;
            cmbDateDirection.Enabled = chkDateFilter.Checked;
            dtpDateFilterStart.Enabled = chkDateFilter.Checked;
            lblDateAnd.Enabled = chkDateFilter.Checked;
            dtpDateFilterEnd.Enabled = chkDateFilter.Checked;
        }

        private void cmbDateDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDateDirection.SelectedIndex == 2)
            {
                lblDateAnd.Visible = true;
                dtpDateFilterEnd.Visible = true;
            }
            else
            {
                lblDateAnd.Visible = false;
                dtpDateFilterEnd.Visible = false;
            }
        }

        private void cmdSelectCommonTypes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstFileTypes.Items.Count; i++)
            {
                if (CommonTypes.Contains(chklstFileTypes.Items[i].ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    chklstFileTypes.SetItemChecked(i, true);
                }
                else
                {
                    chklstFileTypes.SetItemChecked(i, false);
                }
            }
        }

        private void cmdSelectAllTypes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstFileTypes.Items.Count; i++)
            {
                chklstFileTypes.SetItemChecked(i, true);
            }
        }

        private void cmdSelectNoTypes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstFileTypes.Items.Count; i++)
            {
                chklstFileTypes.SetItemChecked(i, false);
            }
        }

        private void chkFileSizeFilter_CheckedChanged(object sender, EventArgs e)
        {
            cmbSizeMode.Enabled = chkFileSizeFilter.Checked;
            nudSizeStart.Enabled = chkFileSizeFilter.Checked;
            cmbSizeStartUnit.Enabled = chkFileSizeFilter.Checked;
            lblSizeAnd.Enabled = chkFileSizeFilter.Checked;
            nudSizeEnd.Enabled = chkFileSizeFilter.Checked;
            cmbSizeEndUnit.Enabled = chkFileSizeFilter.Checked;
        }

        private void cmbSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSizeAnd.Visible = cmbSizeMode.SelectedIndex == 2;
            nudSizeEnd.Visible = cmbSizeMode.SelectedIndex == 2;
            cmbSizeEndUnit.Visible = cmbSizeMode.SelectedIndex == 2;
        }

        private void chkAttributeFilter_CheckedChanged(object sender, EventArgs e)
        {
            chkFilterReadonly.Enabled = chkAttributeFilter.Checked;
            cmbFilterReadonly.Enabled = chkAttributeFilter.Checked && chkFilterReadonly.Checked;
            chkFilterHidden.Enabled = chkAttributeFilter.Checked;
            cmbFilterHidden.Enabled = chkAttributeFilter.Checked && chkFilterHidden.Checked;
            chkFilterArchived.Enabled = chkAttributeFilter.Checked;
            cmbFilterArchived.Enabled = chkFilterArchived.Checked && chkFilterArchived.Checked;
            chkFilterSystem.Enabled = chkAttributeFilter.Checked;
            cmbFilterSystem.Enabled = chkAttributeFilter.Checked && chkFilterSystem.Checked;
        }

        private void chkFilterReadonly_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterReadonly.Enabled = chkFilterReadonly.Checked;
        }

        private void chkFilterHidden_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterHidden.Enabled = chkFilterHidden.Checked;
        }

        private void chkFilterArchived_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterArchived.Enabled = chkFilterArchived.Checked;
        }

        private void chkFilterSystem_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterSystem.Enabled= chkFilterSystem.Checked;
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkActionArchived.Visible = false;
            cmbActionArchived.Visible = false;
            chkActionHidden.Visible = false;
            cmbActionHidden.Visible = false;
            chkActionReadonly.Visible = false;
            cmbActionReadonly.Visible = false;
            chkActionSystem.Visible = false;
            cmbActionSystem.Visible = false;
            lblOutputDirectory.Visible = false;
            txtOutputDirectory.Visible = false;
            cmdBrowserOutput.Visible = false;
            lblDeleteWarning.Visible = false;
            if (cmbActionType.SelectedIndex == 0)
            {
                // Set Attribute
                chkActionArchived.Visible = true;
                cmbActionArchived.Visible = true;
                chkActionHidden.Visible = true;
                cmbActionHidden.Visible = true;
                chkActionReadonly.Visible = true;
                cmbActionReadonly.Visible = true;
                chkActionSystem.Visible = true;
                cmbActionSystem.Visible = true;

            }
            else if (cmbActionType.SelectedIndex == 1 || cmbActionType.SelectedIndex == 2)
            {
                // Copy or Move
                lblOutputDirectory.Visible = true;
                txtOutputDirectory.Visible = true;
                cmdBrowserOutput.Visible = true;
            }
            else if (cmbActionType.SelectedIndex == 3)
            {
                // Delete
                lblDeleteWarning.Visible = true;
            }
        
        }

        private void chkActionReadonly_CheckedChanged(object sender, EventArgs e)
        {
            cmbActionReadonly.Enabled = chkActionReadonly.Checked;
        }

        private void chkActionHidden_CheckedChanged(object sender, EventArgs e)
        {
            cmbActionHidden.Enabled = chkActionHidden.Checked;
        }

        private void chkActionArchived_CheckedChanged(object sender, EventArgs e)
        {
            cmbActionArchived.Enabled = chkActionArchived.Checked;
        }

        private void chkActionSystem_CheckedChanged(object sender, EventArgs e)
        {
            cmbActionSystem.Enabled = chkActionSystem.Checked;
        }

        private void cmdBrowseSourcePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtSourceDirectory.Text = dlg.SelectedPath;
                }
            }
        }

        private void cmdPreviewFilters_Click(object sender, EventArgs e)
        {
            UpdateFilterSelection();
            UpdateDisplay();
        }

        private void chkTypeFilter_CheckedChanged(object sender, EventArgs e)
        {
            chklstFileTypes.Enabled = chkTypeFilter.Checked;
            cmdSelectAllTypes.Enabled = chkTypeFilter.Checked;
            cmdSelectNoTypes.Enabled = chkTypeFilter.Checked;
            cmdSelectCommonTypes.Enabled = chkTypeFilter.Checked;
        }

        private void cmdBrowserOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtOutputDirectory.Text = dlg.SelectedPath;
                }
            }
        }
    }
}
