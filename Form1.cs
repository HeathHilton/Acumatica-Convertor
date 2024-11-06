using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Diagnostics;
using System.Drawing.Text;
using System.Diagnostics.Eventing.Reader;
using System;
using System.Security.Policy;


namespace Acumatica_Convertor
{
    public partial class Form1 : Form
    {

        string dayNum = System.DateTime.UtcNow.DayOfYear.ToString();
        string versionCode = "v1.2.1.";// + dayNum + "a";
        int task = 0;
        //Global Variables
        string selectedFile = "";
        string selectedFolder = "";
        string jetBuiltImport, jetBuiltExport;
        string marginImport, marginExport;
        string message;
        string title;
        bool previewDone = false;
        string importType;
        int count;
        string filepath;

        //Used to store the values of Margin Worksheet
        string[] marginRows = new string[9];
        string[] equipment = new string[5];
        string[] engineering = new string[9];
        string[] engineeringSub = new string[5];
        string[] engineering2 = new string[9];
        string[] install = new string[9];
        string[] installSub = new string[5];
        string[] install2 = new string[9];
        string[] management = new string[9];
        string[] managementSub = new string[5];
        string[] projectManager = new string[9];
        string[] programManager = new string[9];
        string[] admin = new string[9];
        string[] programming = new string[9];
        string[] programmingSub = new string[5];
        string[] programming2 = new string[9];
        string[] shipping = new string[5];
        string[] warranty = new string[5];
        string[] freight = new string[5];
        string[] estimating = new string[5];
        string[] risk = new string[5];
        string[] mileage = new string[9];
        string[] total = new string[9];
        string[] taxes = new string[5];
        string[] projectTotals = new string[9];

        //Used just for the Margin Preview
        string[] marginRowsDisplay = new string[9];
        string[] equipmentDisplay = new string[5];
        string[] engineeringDisplay = new string[9];
        string[] engineeringSubDisplay = new string[5];
        string[] engineering2Display = new string[9];
        string[] installDisplay = new string[9];
        string[] installSubDisplay = new string[5];
        string[] install2Display = new string[9];
        string[] managementDisplay = new string[9];
        string[] managementSubDisplay = new string[5];
        string[] projectManagerDisplay = new string[9];
        string[] programManagerDisplay = new string[9];
        string[] adminDisplay = new string[9];
        string[] programmingDisplay = new string[9];
        string[] programmingSubDisplay = new string[5];
        string[] programming2Display = new string[9];
        string[] shippingDisplay = new string[5];
        string[] warrantyDisplay = new string[5];
        string[] freightDisplay = new string[5];
        string[] estimatingDisplay = new string[5];
        string[] riskDisplay = new string[5];
        string[] mileageDisplay = new string[9];
        string[] totalDisplay = new string[9];
        string[] taxesDisplay = new string[5];
        string[] projectTotalsDisplay = new string[9];

        //Folder Path save location
        string[] paths;

        decimal[] equipmentExport;
        decimal[] engineeringExport;
        decimal[] installExport;
        decimal[] subcontractorExport;
        decimal[] managementExport;
        decimal[] programmingExport;
        decimal[] shippingExport;
        decimal[] riskExport;
        decimal[] mileageExport;
        decimal[] estimatingExport;
        decimal[] freightExport;
        decimal[] warrantyExport;
        decimal[] subtotalExport;
        decimal[] taxesExport;
        decimal[] projectTotalsExport;

        decimal burdenRate = 18;
        decimal engineeringRate = 65;

        List<string> listA = new List<string>();
        int arraySaveCount, importLineNumber;

        //string[] equipment = new string[5];

        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = versionCode + dayNum + "a";
            //int formHeight = this.Height;
            //lblVersion.Text = formHeight.ToString();
            //this.imageInfo.Location = new Point(this.imageInfo.Location.X, this.panel1.Height - 145);
            //this.lblVersion.Location = new Point(this.lblVersion.Location.X, this.panel1.Height - 100);
        }


        private void BtnJetParts_Click(object sender, EventArgs e)
        {
            switchToJetParts();
        }
        private void BtnMargin_Click(object sender, EventArgs e)
        {
            switchToMargin();
        }
        private void BtnSalesforce_Click(object sender, EventArgs e)
        {
            switchToSalesforce();
        }

        private void imageJet_Click(object sender, EventArgs e)
        {
            //switchToJetParts();
        }
        private void imageMargin_Click(object sender, EventArgs e)
        {
            //switchToMargin();
        }

        private void switchToJetParts()
        {
            task = 1;
            lblMethodTitle.Text = "Jetbuilt Parts Purchase Order";
            BtnJetParts.FlatStyle = FlatStyle.Popup;
            BtnJetParts.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatStyle = FlatStyle.Flat;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatStyle = FlatStyle.Flat;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            gbCSVImport.Visible = true;
            rtbJetOutputPreview.Text = "";
            cbChangeOrder.Visible = false;
            cbChangeOrder.Checked = false;
            cbMilesToInstall.Visible = false;
            taxStatusLBL.Visible = true;
            exemptCB.Visible = true;

            title = "Future Feature";
            message = "This feature is not yet available.";
            MessageBox.Show(message, title);
        }
        private void switchToMargin()
        {
            task = 2;
            lblMethodTitle.Text = "Margin Worksheet Convertion";
            BtnJetParts.FlatStyle = FlatStyle.Flat;
            BtnJetParts.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatStyle = FlatStyle.Popup;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatStyle = FlatStyle.Flat;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            gbCSVImport.Visible = true;
            rtbJetOutputPreview.Text = "";
            cbChangeOrder.Visible = true;
            cbChangeOrder.Checked = false;
            cbMilesToInstall.Visible = true;
            cbMilesToInstall.Checked = false;
            taxStatusLBL.Visible = false;
            exemptCB.Visible = false;
            exemptCB.TabIndex = 0;


        }
        private void switchToSalesforce()
        {
            task = 3;
            lblMethodTitle.Text = "Salesforce Import Conversion";
            BtnJetParts.FlatStyle = FlatStyle.Flat;
            BtnJetParts.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatStyle = FlatStyle.Flat;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatStyle = FlatStyle.Popup;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            gbCSVImport.Visible = true;
            rtbJetOutputPreview.Text = "";
            cbChangeOrder.Visible = true;
            cbChangeOrder.Checked = false;
            cbMilesToInstall.Visible = true;
            cbMilesToInstall.Checked = false;
            taxStatusLBL.Visible = false;
            exemptCB.Visible = false;
            exemptCB.TabIndex = 0;

            title = "Future Feature";
            message = "This feature is not yet available.";
            MessageBox.Show(message, title);


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblMethodTitle_Click(object sender, EventArgs e)
        {

        }

        private void imageInfo_Click(object sender, EventArgs e)
        {
            //if (task == 0)
            //{
            MessageBox.Show("Should you have any questions or find something that appears to be an error, please reach out to Heath Hilton.", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //}
            //else
            {
                //    MessageBox.Show("Please fill out all of the required fields or your selected task will not function properly.", "Overview", MessageBoxButtons.OK,
                //        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void setImportBtn_Click(object sender, EventArgs e)
        {
            if (task == 1)
            {
                importType = "jet";
            }
            else if (task == 2)
            {
                importType = "margin";
            }
            getImportLocation(importType);
            previewDone = false;
        }

        private void getImportLocation(string type)
        {

            if (importType == "jet")
            {
                OpenFileDialog openDialog = new()
                {
                    Title = "Select a .csv file",
                    Filter = "Text Files (*.csv)|*.csv" + "|" +
                             //"Excel Files (*.xlsx)|*.xlsx" + "|" +
                             "All Files (*.*)|*.*"
                };

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = openDialog.FileName;
                    if (selectedFile.Length > 100)
                    {
                        string newDisplayPath = selectedFile.Substring(selectedFile.Length - 100, 100);
                        importPathLbl.Text = "... " + newDisplayPath + " jet";
                    }
                    else
                    {
                        importPathLbl.Text = selectedFile + " jet";
                    }
                    //Debug.WriteLine(selectedFile);
                }

            }
            else if (importType == "margin")
            {
                OpenFileDialog openDialog = new()
                {
                    Title = "Select a .csv file",
                    Filter = "Text Files (*.csv)|*.csv" + "|" +
                             //"Excel Files (*.xlsx)|*.xlsx" + "|" +
                             "All Files (*.*)|*.*"
                };
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = openDialog.FileName;
                    if (selectedFile.Length > 100)
                    {
                        string newDisplayPath = selectedFile.Substring(selectedFile.Length - 100, 100);
                        importPathLbl.Text = "... " + newDisplayPath;
                    }
                    else
                    {
                        importPathLbl.Text = selectedFile + " margin";
                    }
                    //Debug.WriteLine(selectedFile);
                }
            }
        }

        private void setExportBtn_Click(object sender, EventArgs e)
        {
            if (previewDone)
            {
                //Debug.WriteLine("Made it to the export function");
                using var dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedFolder = dialog.SelectedPath;

                    //if (openDialog.ShowDialog() == DialogResult.OK)
                    if (selectedFolder.Length > 0)
                    {
                        if (selectedFolder.Length > 100)
                        {
                            string newDisplayPath = selectedFolder.Substring(selectedFolder.Length - 100, 100);
                            exportPathLbl.Text = "... " + newDisplayPath;
                        }
                        else
                        {
                            exportPathLbl.Text = selectedFolder;
                        }
                    }
                }
            }
            else
            {
                title = "Export Error";
                message = "Please verify via the 'Quick View' to verify that the import file is as expected prior to exporting.";
                MessageBox.Show(message, title);

            }
        }

        public void btnQView_Click(object sender, EventArgs e)
        {

            //************************Colapsed Here*******************************


            if (importType == "jet")
            {
                var companyImport = new List<string>();
                var shipToImport = new List<string>();
                var streetAddressImport = new List<string>();
                var cityImport = new List<string>();
                var stateImport = new List<string>();
                var zipcodeImport = new List<string>();
                var countryImport = new List<string>();
                var shipTypeImport = new List<string>();
                var dateImport = new List<string>();
                var poImport = new List<string>();
                var createdByImport = new List<string>();
                var projectImport = new List<string>();
                var vendorImport = new List<string>();
                var dealerImport = new List<string>();
                var poNotesImport = new List<string>();
                var productIDImport = new List<string>();
                var manufacturerImport = new List<string>();
                var modelImport = new List<string>();
                var partNumberImport = new List<string>();
                var shortDescriptionImport = new List<string>();
                var notesImport = new List<string>();
                var quantityImport = new List<string>();
                var priceImport = new List<string>();
                var priceExtImport = new List<string>();

                OpenFileDialog openDialog = new();
                //Debug.WriteLine(selectedFile);

                try
                {
                    using (var rd = new StreamReader(selectedFile))
                    {
                        while (!rd.EndOfStream)
                        {
                            var splits = Regex.Split(rd.ReadLine(), "[,]{1}(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                            companyImport.Add(splits[0]);
                            shipToImport.Add(splits[1]);
                            streetAddressImport.Add(splits[2]);
                            cityImport.Add(splits[3]);
                            stateImport.Add(splits[4]);
                            zipcodeImport.Add(splits[5]);
                            countryImport.Add(splits[6]);
                            shipTypeImport.Add(splits[7]);
                            dateImport.Add(splits[8]);
                            poImport.Add(splits[9]);
                            createdByImport.Add(splits[10]);
                            projectImport.Add(splits[11]);
                            vendorImport.Add(splits[12]);
                            dealerImport.Add(splits[13]);
                            poNotesImport.Add(splits[14]);
                            productIDImport.Add(splits[15]);
                            manufacturerImport.Add(splits[16]);
                            modelImport.Add(splits[17]);
                            partNumberImport.Add(splits[18]);
                            shortDescriptionImport.Add(splits[19]);
                            notesImport.Add(splits[20]);
                            quantityImport.Add(splits[21]);
                            priceImport.Add(splits[22]);
                            priceExtImport.Add(splits[23]);
                        }
                    }

                    //string[] paths = { selectedFolder, jobNumET.Text + " - Jetbuilt Export.csv" };
                    //string filePath = Path.Combine(paths);

                    //before the loop
                    var csv = new StringBuilder();
                    var rows = companyImport.Count;
                    //Debug.WriteLine(rows);

                    //in the loop
                    ////var newLine = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\"", "Inventory ID", "Warehouse", "Line Description", "UOM", "Order Qty.", "Qty. On Receipts", "Unit Cost", "Ext. Cost", "Amount", "Complete (%)", "Receipt Action", "Tax Category", "Account", "Description", "Sub.", "Accrual Account", "Accrual Sub.", "Project", "Project Task", "Cost Code", "Requested", "Promised", "Completed", "Cancelled", "Closed", "Billed Qty.", "Billed Amount", "Unbilled Qty.", "Unbilled Amount", "Blanket PO Type", "Blanket PO Nbr.", "Billing Based On");
                    ////csv.AppendLine(newLine);
                    var newLine = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, {30}, {31}", "Inventory ID", "Warehouse", "Line Description", "UOM", "Order Qty.", "Qty. On Receipts", "Unit Cost", "Ext. Cost", "Amount", "Complete (%)", "Receipt Action", "Tax Category", "Account", "Description", "Sub.", "Accrual Account", "Accrual Sub.", "Project", "Project Task", "Cost Code", "Requested", "Promised", "Completed", "Cancelled", "Closed", "Billed Qty.", "Billed Amount", "Unbilled Qty.", "Unbilled Amount", "Blanket PO Type", "Blanket PO Nbr.", "Billing Based On");
                    rtbJetOutputPreview.Text = newLine;

                    for (int i = 1; i < rows; i++)
                    {
                        var inventoryIDExport = "PROJ MATERIAL";
                        var warehouseExport = "ENVIQ";
                        var lineDescriptionExport = manufacturerImport[i].ToString() + " " + modelImport[i].ToString();
                        var uomExport = "EACH";
                        var orderQtyExport = quantityImport[i].ToString();
                        var qtyOnReceipts = "0.000000";
                        var unitCostExport = priceImport[i].ToString();
                        var extCostExport = priceExtImport[i].ToString();
                        var amountExport = priceExtImport[i].ToString();
                        var completeOnExport = "100.00";
                        var receiptActionExport = "Accept but Warn";
                        var taxCategoryExport = exemptCB.Text;
                        var accountExport = 5020;
                        var descriptionExport = "Materials";
                        var subExport = "200.00";
                        var accrualAccountExport = "";
                        var accrualSubExport = "";
                        var projectExport = jobNumET.Text;
                        var projectTaskExport = "005";
                        var costCodeExport = 100;
                        var requestedExport = dateImport[i].ToString();
                        requestedExport = requestedExport.Trim('"');
                        var promisedExport = dateImport[i].ToString();
                        promisedExport = promisedExport.Trim('"');
                        var completedExport = "False";
                        var cancelledExport = "False";
                        var closedExport = "False";
                        var billedQtyExport = "0.00000";
                        var billedAmountExport = 0.00;
                        var unbilledQtyExport = quantityImport[i].ToString();
                        var unbilledAmountExport = priceExtImport[i].ToString();
                        var blanketPOTypeExport = "";
                        var blanketPONbrExport = "";
                        var billingBasedOnExport = "Order";

                        //The line to output to the csv file
                        newLine = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, {30}, {31}", inventoryIDExport, warehouseExport, lineDescriptionExport, uomExport, orderQtyExport, qtyOnReceipts, unitCostExport, extCostExport, amountExport, completeOnExport, receiptActionExport, taxCategoryExport, accountExport, descriptionExport, subExport, accrualAccountExport, accrualSubExport, projectExport, projectTaskExport, costCodeExport, requestedExport, promisedExport, completedExport, cancelledExport, closedExport, billedQtyExport, billedAmountExport, unbilledQtyExport, unbilledAmountExport, blanketPOTypeExport, blanketPONbrExport, billingBasedOnExport);
                        //csv.AppendLine(newLine);
                        rtbJetOutputPreview.Text += "\n" + newLine;
                    }
                    //after your loop
                    //File.WriteAllText(filePath, csv.ToString());



                    title = "Quick Preview Complete";
                    message = "The file should have been imported and is showing what will be exported. If everything looks as expected, proceed with the export process.";
                    MessageBox.Show(message, title);
                    previewDone = true;
                }
                catch
                {
                    title = "Quick Preview Import Error";
                    message = "Please verify that the import file is not open or that it was of the correct file type.";
                    MessageBox.Show(message, title);
                    previewDone = false;
                }

            }
            else if (importType == "margin")
            {
                title = "Import Type";
                string tempString = "";
                if (cbChangeOrder.Checked == true)
                {
                    tempString = "project CHANGE ORDER.";
                }
                else
                {
                    tempString = "FULL PROJECT.";
                }
                message = "Please confirm that you are importing a " + tempString;
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (var streamReader = new StreamReader(selectedFile))
                        {
                            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                            {
                                StreamReader reader = null;
                                reader = new StreamReader(File.OpenRead(selectedFile));
                                //List<string> listA = new List<string>();



                                var lines = File.ReadAllLines(selectedFile);
                                count = lines.Length;

                                if (count != 25)
                                {
                                    title = "Import Error";
                                    //string rowCount = marginRows[i].ToString();
                                    message = "It appears as though you are importing a file with an unexpection amount of rows.\n\n" + count.ToString() + " rows";
                                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    //Clear out the Preview
                                    rtbJetOutputPreview.Text = "";

                                    importLineNumber = 0;

                                    while (!reader.EndOfStream)
                                    {
                                        string uniqueLineName;
                                        var importLine = reader.ReadLine();
                                        var importLineSplit = importLine.Split(',');

                                        uniqueLineName = importLineSplit[0];
                                        switch (uniqueLineName)
                                        {
                                            case "Engineering":
                                                if (importLineNumber == 2)
                                                {
                                                    uniqueLineName = "Engineering";
                                                }
                                                else
                                                {
                                                    uniqueLineName = "Engineering2";
                                                }
                                                break;
                                            case "Sub-Contract":
                                                if (importLineNumber == 3)
                                                {
                                                    uniqueLineName = "EngineeringSub";
                                                }
                                                else if (importLineNumber == 6)
                                                {
                                                    uniqueLineName = "InstallSub";
                                                }
                                                else if (importLineNumber == 9)
                                                {
                                                    uniqueLineName = "ManagementSub";
                                                }
                                                else if (importLineNumber == 14)
                                                {
                                                    uniqueLineName = "ProgrammingSub";
                                                }
                                                break;
                                            case "Install":
                                                if (importLineNumber == 5)
                                                {
                                                    uniqueLineName = "Install";
                                                }
                                                else
                                                {
                                                    uniqueLineName = "Install2";
                                                }
                                                break;
                                            case "Programming":
                                                if (importLineNumber == 13)
                                                {
                                                    uniqueLineName = "Programming";
                                                }
                                                else
                                                {
                                                    uniqueLineName = "Programming2";
                                                }
                                                break;
                                            default:
                                                uniqueLineName = importLineSplit[0];
                                                break;

                                        }
                                        importLineNumber = marginImportLines(importLineSplit, importLineNumber, uniqueLineName);
                                    }
                                }
                            }
                        }

                        //after your loop
                        //File.WriteAllText(filePath, csv.ToString());

                        if (count == 25)
                        {
                            if (rtbJetOutputPreview.Text.Length > 300)
                            {
                                title = "Quick Preview Complete";
                                message = "The file should have been imported and is showing what will be exported. If everything looks as expected, proceed with the export process.";
                                MessageBox.Show(message, title);
                                previewDone = true;
                                //marginConvertion();
                            }
                            else
                            {
                                title = "Possible Quick Preview Import Error";
                                message = "The preview doesn't appear to have worked as expected or your file is slightly out of norm.\n\nDoes the output appear to be correct?";
                                result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    previewDone = true;
                                }
                                else
                                {
                                    previewDone = false;
                                }
                            }
                        }
                    }
                    catch
                    {
                        title = "Quick Preview Import Error";
                        message = "Please verify that the import file is not open or that it was of the correct file type.";
                        MessageBox.Show(message, title);
                        previewDone = false;
                    }

                }

            }
        }

        public string setExportCellLength(string cell, int i)
        {
            while (cell.Length < 16)
            {
                if (i == 0)
                {
                    cell = cell + " ";
                }
                else
                {
                    cell = " " + cell;
                }
            }

            return cell;
        }

        public int marginImportLines(string[] importLineSplit, int importLineNumber, string uniqueLineName)
        {

            string testString = importLineSplit[0];

            switch (uniqueLineName)
            {
                case "Margin Worksheet":
                    for (int i = 0; i < 9; i++)
                    {
                        marginRows.SetValue(importLineSplit[i], i);
                        marginRowsDisplay[i] = setExportCellLength(marginRows[i], i);
                        Debug.WriteLine(i + ": " + marginRowsDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += setExportDisplayPreview(marginRowsDisplay.Length, marginRowsDisplay);
                    break;

                case "Equipment":
                    for (int i = 0; i < 5; i++)
                    {
                        equipment.SetValue(importLineSplit[i], i);
                        equipmentDisplay[i] = setExportCellLength(equipment[i], i);
                        Debug.WriteLine(i + ": " + equipmentDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(equipmentDisplay.Length, equipmentDisplay);
                    break;

                case "Engineering":
                    for (int i = 0; i < 9; i++)
                    {
                        engineering.SetValue(importLineSplit[i], i);
                        /*********************************************************************************************************************/
                        engineeringDisplay[i] = setExportCellLength(engineering[i], i);
                        Debug.WriteLine(i + ": " + engineeringDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(engineeringDisplay.Length, engineeringDisplay);
                    break;

                case "EngineeringSub":
                    for (int i = 0; i < 5; i++)
                    {
                        engineeringSub.SetValue(importLineSplit[i], i);
                        engineeringSubDisplay[i] = setExportCellLength(engineeringSub[i], i);
                        Debug.WriteLine(i + ": " + engineeringSubDisplay[i] + " - " + importLineNumber);
                    }
                    //arraySaveCount += engineeringSub.Length;
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(engineeringSubDisplay.Length, engineeringSubDisplay);
                    break;

                case "Engineering2":
                    for (int i = 0; i < 9; i++)
                    {
                        engineering2.SetValue(importLineSplit[i], i);
                        engineering2Display[i] = setExportCellLength(engineering2[i], i);
                        Debug.WriteLine(i + ": " + engineering2Display[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(engineering2Display.Length, engineering2Display);
                    break;

                case "Install":
                    for (int i = 0; i < 9; i++)
                    {
                        install.SetValue(importLineSplit[i], i);
                        installDisplay[i] = setExportCellLength(install[i], i);
                        Debug.WriteLine(i + ": " + installDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(installDisplay.Length, installDisplay);
                    break;

                case "InstallSub":
                    for (int i = 0; i < 5; i++)
                    {
                        installSub.SetValue(importLineSplit[i], i);
                        installSubDisplay[i] = setExportCellLength(installSub[i], i);
                        Debug.WriteLine(i + ": " + installSubDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(installSubDisplay.Length, installSubDisplay);
                    break;

                case "Install2":
                    for (int i = 0; i < 9; i++)
                    {
                        install2.SetValue(importLineSplit[i], i);
                        install2Display[i] = setExportCellLength(install2[i], i);
                        Debug.WriteLine(i + ": " + install2Display[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(install2Display.Length, install2Display);
                    break;

                case "Management":
                    for (int i = 0; i < 9; i++)
                    {
                        management.SetValue(importLineSplit[i], i);
                        managementDisplay[i] = setExportCellLength(management[i], i);
                        Debug.WriteLine(i + ": " + managementDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(managementDisplay.Length, managementDisplay);
                    break;

                case "ManagementSub":
                    for (int i = 0; i < 5; i++)
                    {
                        managementSub.SetValue(importLineSplit[i], i);
                        managementSubDisplay[i] = setExportCellLength(managementSub[i], i);
                        Debug.WriteLine(i + ": " + managementSubDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(managementSubDisplay.Length, managementSubDisplay);
                    break;

                case "Project Manager":
                    for (int i = 0; i < 9; i++)
                    {
                        projectManager.SetValue(importLineSplit[i], i);
                        projectManagerDisplay[i] = setExportCellLength(projectManager[i], i);
                        Debug.WriteLine(i + ": " + projectManagerDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(projectManagerDisplay.Length, projectManagerDisplay);
                    break;

                case "Program Manager":
                    for (int i = 0; i < 9; i++)
                    {
                        programManager.SetValue(importLineSplit[i], i);
                        programManagerDisplay[i] = setExportCellLength(programManager[i], i);
                        Debug.WriteLine(i + ": " + programManagerDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(programManagerDisplay.Length, programManagerDisplay);
                    break;

                case "Admin":
                    for (int i = 0; i < 9; i++)
                    {
                        admin.SetValue(importLineSplit[i], i);
                        adminDisplay[i] = setExportCellLength(admin[i], i);
                        Debug.WriteLine(i + ": " + adminDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(adminDisplay.Length, adminDisplay);
                    break;

                case "Programming":
                    for (int i = 0; i < 9; i++)
                    {
                        programming.SetValue(importLineSplit[i], i);
                        programmingDisplay[i] = setExportCellLength(programming[i], i);
                        Debug.WriteLine(i + ": " + programmingDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(programmingDisplay.Length, programmingDisplay);
                    break;

                case "ProgrammingSub":
                    for (int i = 0; i < 5; i++)
                    {
                        programmingSub.SetValue(importLineSplit[i], i);
                        programmingSubDisplay[i] = setExportCellLength(programmingSub[i], i);
                        Debug.WriteLine(i + ": " + programmingSubDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(programmingSubDisplay.Length, programmingSubDisplay);
                    break;

                case "Programming2":
                    for (int i = 0; i < 9; i++)
                    {
                        programming2.SetValue(importLineSplit[i], i);
                        programming2Display[i] = setExportCellLength(programming2[i], i);
                        Debug.WriteLine(i + ": " + programming2Display[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(programming2Display.Length, programming2Display);
                    break;

                case "Shipping":
                    for (int i = 0; i < 5; i++)
                    {
                        shipping.SetValue(importLineSplit[i], i);
                        shippingDisplay[i] = setExportCellLength(shipping[i], i);
                        Debug.WriteLine(i + ": " + shippingDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(shippingDisplay.Length, shippingDisplay);
                    break;

                case "Warranty":
                    for (int i = 0; i < 5; i++)
                    {
                        warranty.SetValue(importLineSplit[i], i);
                        warrantyDisplay[i] = setExportCellLength(warranty[i], i);
                        Debug.WriteLine(i + ": " + warrantyDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(warrantyDisplay.Length, warrantyDisplay);
                    break;

                case "Freight":
                    for (int i = 0; i < 5; i++)
                    {
                        freight.SetValue(importLineSplit[i], i);
                        freightDisplay[i] = setExportCellLength(freight[i], i);
                        Debug.WriteLine(i + ": " + freightDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(freightDisplay.Length, freightDisplay);
                    break;

                case "Estimating":
                    for (int i = 0; i < 5; i++)
                    {
                        estimating.SetValue(importLineSplit[i], i);
                        estimatingDisplay[i] = setExportCellLength(estimating[i], i);
                        Debug.WriteLine(i + ": " + estimatingDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(estimatingDisplay.Length, estimatingDisplay);
                    break;

                case "Risk":
                    for (int i = 0; i < 5; i++)
                    {
                        risk.SetValue(importLineSplit[i], i);
                        riskDisplay[i] = setExportCellLength(risk[i], i);
                        Debug.WriteLine(i + ": " + riskDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(riskDisplay.Length, riskDisplay);
                    break;

                case "Mileage":
                    for (int i = 0; i < 9; i++)
                    {
                        mileage.SetValue(importLineSplit[i], i);
                        mileageDisplay[i] = setExportCellLength(mileage[i], i);
                        Debug.WriteLine(i + ": " + mileageDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(mileageDisplay.Length, mileageDisplay);
                    break;

                case "Total":
                    for (int i = 0; i < 9; i++)
                    {
                        total.SetValue(importLineSplit[i], i);
                        totalDisplay[i] = setExportCellLength(total[i], i);
                        Debug.WriteLine(i + ": " + totalDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(totalDisplay.Length, totalDisplay);
                    break;

                case "Taxes":
                    for (int i = 0; i < 5; i++)
                    {
                        taxes.SetValue(importLineSplit[i], i);
                        taxesDisplay[i] = setExportCellLength(taxes[i], i);
                        Debug.WriteLine(i + ": " + taxesDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(taxesDisplay.Length, taxesDisplay);
                    break;

                case "Project Totals":
                    for (int i = 0; i < 9; i++)
                    {
                        projectTotals.SetValue(importLineSplit[i], i);
                        projectTotalsDisplay[i] = setExportCellLength(projectTotals[i], i);
                        Debug.WriteLine(i + ": " + projectTotalsDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(projectTotalsDisplay.Length, projectTotalsDisplay);
                    break;

                case "Option/CO Totals":
                    for (int i = 0; i < 9; i++)
                    {
                        projectTotals.SetValue(importLineSplit[i], i);
                        projectTotalsDisplay[i] = setExportCellLength(projectTotals[i], i);
                        Debug.WriteLine(i + ": " + projectTotalsDisplay[i] + " - " + importLineNumber);
                    }
                    rtbJetOutputPreview.Text += "\n" + setExportDisplayPreview(projectTotalsDisplay.Length, projectTotalsDisplay);
                    break;

                default:
                    //Nothing
                    break;
            }
            return importLineNumber += 1;
        }

        public string setExportDisplayPreview(int rowCount, string[] rows)
        {
            if (rowCount == 5)
            {
                string newLine = string.Format("{0}, {1}, {2}, {3}, {4}", rows[0], rows[1], rows[2], rows[3], rows[4]);
                //csv.AppendLine(newLine);
                return newLine;
            }
            else
            {
                string newLine = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", rows[0], rows[1], rows[2], rows[3], rows[4], rows[5], rows[6], rows[7], rows[8]);
                //csv.AppendLine(newLine);
                return newLine;
            }
        }


        private void btnQView_Click2(object sender, EventArgs e)
        {
            var companyImport = new List<string>();
            var shipToImport = new List<string>();
            var streetAddressImport = new List<string>();
            var cityImport = new List<string>();
            var stateImport = new List<string>();
            var zipcodeImport = new List<string>();
            var countryImport = new List<string>();
            var shipTypeImport = new List<string>();
            var dateImport = new List<string>();
            var poImport = new List<string>();
            var createdByImport = new List<string>();
            var projectImport = new List<string>();
            var vendorImport = new List<string>();
            var dealerImport = new List<string>();
            var poNotesImport = new List<string>();
            var productIDImport = new List<string>();
            var manufacturerImport = new List<string>();
            var modelImport = new List<string>();
            var partNumberImport = new List<string>();
            var shortDescriptionImport = new List<string>();
            var notesImport = new List<string>();
            var quantityImport = new List<string>();
            var priceImport = new List<string>();
            var priceExtImport = new List<string>();

            OpenFileDialog openDialog = new();
            //Debug.WriteLine(selectedFile);


            try
            {
                using (var rd = new StreamReader(selectedFile))
                {
                    while (!rd.EndOfStream)
                    {
                        var splits = Regex.Split(rd.ReadLine(), "[,]{1}(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                        companyImport.Add(splits[0]);
                        shipToImport.Add(splits[1]);
                        streetAddressImport.Add(splits[2]);
                        cityImport.Add(splits[3]);
                        stateImport.Add(splits[4]);
                        zipcodeImport.Add(splits[5]);
                        countryImport.Add(splits[6]);
                        shipTypeImport.Add(splits[7]);
                        dateImport.Add(splits[8]);
                        poImport.Add(splits[9]);
                        createdByImport.Add(splits[10]);
                        projectImport.Add(splits[11]);
                        vendorImport.Add(splits[12]);
                        dealerImport.Add(splits[13]);
                        poNotesImport.Add(splits[14]);
                        productIDImport.Add(splits[15]);
                        manufacturerImport.Add(splits[16]);
                        modelImport.Add(splits[17]);
                        partNumberImport.Add(splits[18]);
                        shortDescriptionImport.Add(splits[19]);
                        notesImport.Add(splits[20]);
                        quantityImport.Add(splits[21]);
                        priceImport.Add(splits[22]);
                        priceExtImport.Add(splits[23]);
                    }
                }

                //string[] paths = { selectedFolder, jobNumET.Text + " - Jetbuilt Export.csv" };
                //string filePath = Path.Combine(paths);

                //before the loop
                var csv = new StringBuilder();
                var rows = companyImport.Count;
                //Debug.WriteLine(rows);

                //in the loop
                var newLine = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\"", "Inventory ID", "Warehouse", "Line Description", "UOM", "Order Qty.", "Qty. On Receipts", "Unit Cost", "Ext. Cost", "Amount", "Complete (%)", "Receipt Action", "Tax Category", "Account", "Description", "Sub.", "Accrual Account", "Accrual Sub.", "Project", "Project Task", "Cost Code", "Requested", "Promised", "Completed", "Cancelled", "Closed", "Billed Qty.", "Billed Amount", "Unbilled Qty.", "Unbilled Amount", "Blanket PO Type", "Blanket PO Nbr.", "Billing Based On");
                csv.AppendLine(newLine);
                //var newLine = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\"", "Inventory ID", "Warehouse", "Line Description", "UOM", "Order Qty.", "Qty. On Receipts", "Unit Cost", "Ext. Cost", "Amount", "Complete (%)", "Receipt Action", "Tax Category", "Account", "Description", "Sub.", "Accrual Account", "Accrual Sub.", "Project", "Project Task", "Cost Code", "Requested", "Promised", "Completed", "Cancelled", "Closed", "Billed Qty.", "Billed Amount", "Unbilled Qty.", "Unbilled Amount", "Blanket PO Type", "Blanket PO Nbr.", "Billing Based On");
                //rtbJetOutputPreview.Text = newLine;

                for (int i = 1; i < rows; i++)
                {
                    var inventoryIDExport = "PROJ MATERIAL";
                    var warehouseExport = "ENVIQ";
                    var lineDescriptionExport = manufacturerImport[i].ToString() + " " + modelImport[i].ToString();
                    var uomExport = "EACH";
                    var orderQtyExport = quantityImport[i].ToString();
                    var qtyOnReceipts = "0.000000";
                    var unitCostExport = priceImport[i].ToString();
                    var extCostExport = priceExtImport[i].ToString();
                    var amountExport = priceExtImport[i].ToString();
                    var completeOnExport = "100.00";
                    var receiptActionExport = "Accept but Warn";
                    var taxCategoryExport = exemptCB.Text;
                    var accountExport = 5020;
                    var descriptionExport = "Materials";
                    var subExport = "200.00";
                    var accrualAccountExport = "";
                    var accrualSubExport = "";
                    var projectExport = jobNumET.Text;
                    var projectTaskExport = "005";
                    var costCodeExport = 100;
                    var requestedExport = dateImport[i].ToString();
                    requestedExport = requestedExport.Trim('"');
                    var promisedExport = dateImport[i].ToString();
                    promisedExport = promisedExport.Trim('"');
                    var completedExport = "False";
                    var cancelledExport = "False";
                    var closedExport = "False";
                    var billedQtyExport = "0.00000";
                    var billedAmountExport = 0.00;
                    var unbilledQtyExport = quantityImport[i].ToString();
                    var unbilledAmountExport = priceExtImport[i].ToString();
                    var blanketPOTypeExport = "";
                    var blanketPONbrExport = "";
                    var billingBasedOnExport = "Order";

                    //The line to output to the csv file
                    newLine = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\"", inventoryIDExport, warehouseExport, lineDescriptionExport, uomExport, orderQtyExport, qtyOnReceipts, unitCostExport, extCostExport, amountExport, completeOnExport, receiptActionExport, taxCategoryExport, accountExport, descriptionExport, subExport, accrualAccountExport, accrualSubExport, projectExport, projectTaskExport, costCodeExport, requestedExport, promisedExport, completedExport, cancelledExport, closedExport, billedQtyExport, billedAmountExport, unbilledQtyExport, unbilledAmountExport, blanketPOTypeExport, blanketPONbrExport, billingBasedOnExport);
                    //csv.AppendLine(newLine);
                    rtbJetOutputPreview.Text += "\n" + newLine;
                }
                //after your loop
                //File.WriteAllText(filePath, csv.ToString());

                title = "Quick Preview Complete";
                message = "The file should have been imported and is showing what will be exported. If everything looks correct, proceed with the export process.";
                MessageBox.Show(message, title);
            }
            catch
            {
                title = "Quick Preview Import Error";
                message = "Please verify that the import file is not open or that it was of the correct file type.";
                MessageBox.Show(message, title);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            jobNumET.Text = "";
            selectedFile = "";
            importPathLbl.Text = "Import Path";
            selectedFolder = "";
            exportPathLbl.Text = "Export Path";
            exemptCB.ResetText();
            rtbJetOutputPreview.ResetText();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            int missingInfo = 0;
            message = "All fields are required.\n\nItem(s) missing:";

            if (jobNumET.Text == "")
            {
                missingInfo += 1;
                //Debug.WriteLine(missingInfo);
                message += "\nJob Number";
            }
            if (task == 1)
            {
                if (exemptCB.SelectedIndex < 1)
                {
                    missingInfo += 2;
                    //Debug.WriteLine(missingInfo);
                    message += "\nExempt Status";
                }
            }
            if (selectedFile.Length == 0)
            {
                missingInfo += 4;
                //Debug.WriteLine(missingInfo);
                message += "\nValid Import Path";
            }
            if (selectedFolder.Length == 0)
            {
                missingInfo += 8;
                //Debug.WriteLine(missingInfo);
                message += "\nValid Output Path";
            }
            if (missingInfo != 0)
            {
                title = "Incomplete Entry";
                MessageBox.Show(message, title);
            }
            else
            {
                marginExporter();
            }
        }

        public string marginExportLineBuilder(string rowName, string costCode, string accountGroup, string description, string UOM, string rateAmount)
        {
            string newLine;
            string quantity;
            if (rateAmount == "" || rateAmount == "0.00" || decimal.Parse(rateAmount) == 0)
            {
                quantity = "0,";
            }
            else
            {
                quantity = "1,";
            }
            return newLine = string.Format(rowName + costCode + accountGroup + description + UOM + quantity + rateAmount);
        }


        public void marginExporter()
        {
            //string[] paths;

            string tempStringToMakeThisFlippingWork;

            if (cbChangeOrder.Checked == true)
            {
                tempStringToMakeThisFlippingWork = " - Margin Export Change Order.csv";
            }
            else
            {
                tempStringToMakeThisFlippingWork = " - Margin Export.csv";
            }

            string[] paths = { selectedFolder, jobNumET.Text + tempStringToMakeThisFlippingWork };
            string filePath = Path.Combine(paths);

            //before the loop
            var csv = new StringBuilder();

            if (cbChangeOrder.Checked == true)
            {
                csv.AppendLine(string.Format("Project Task," + "Cost Code," + "Account Group," + "Description," + "UOM," + "Quantity," + "Unit Rate"));
            }
            else
            {
                csv.AppendLine(string.Format("Project Task," + "Cost Code," + "Account Group," + "Description," + "UOM," + "Original Budgeted Quantity," + "Original Budgeted Amount"));
            }

            csv.AppendLine(marginExportLineBuilder("005,", "100,", "MATERIAL,", "Material,", "EACH,", string.Format(decimal.Parse(equipment[3]).ToString())));
            csv.AppendLine(marginExportLineBuilder("010,", "140,", "MATERIAL,", "EQUIPMENT,", "EACH,", "0.00"));
            csv.AppendLine(marginExportLineBuilder("015,", "190,", "MATERIAL,", "Freight,", "EACH,", decimal.Parse(freight[3]).ToString()));

            if (cbMilesToInstall.Checked == true)
            {
                decimal testNum1 = decimal.Parse(install2[3]) / decimal.Parse(install2[5]);
                decimal testNum2 = decimal.Parse(mileage[3]) / decimal.Parse(mileage[5]);
                decimal testNum3 = testNum1 + testNum2;
                decimal testNum4 = testNum3 * 18;
                testNum4 = Math.Round(testNum4, 2, MidpointRounding.AwayFromZero);
                decimal testNum5 = decimal.Parse(install2[3]) + decimal.Parse(mileage[3]) - testNum4;
                testNum5 = Math.Round(testNum5, 2, MidpointRounding.AwayFromZero);

                csv.AppendLine(marginExportLineBuilder("020,", "200,", "LABBURDEN,", "Technician/Field Labor,", "LS,", testNum4.ToString()));
                csv.AppendLine(marginExportLineBuilder("020,", "200,", "LABOR,", "Technician/Field Labor,", "EACH,", testNum5.ToString()));
            }
            else
            {
                csv.AppendLine(marginExportLineBuilder("020,", "200,", "LABBURDEN,", "Technician/Field Labor,", "LS,", (decimal.Parse(install2[7]) * burdenRate).ToString()));
                csv.AppendLine(marginExportLineBuilder("020,", "200,", "LABOR,", "Technician/Field Labor,", "EACH,", (decimal.Parse(install2[3]) - (decimal.Parse(install2[7]) * burdenRate)).ToString()));
            }

            csv.AppendLine(marginExportLineBuilder("025,", "210,", "LABBURDEN,", "Project Manager,", "LS,", (decimal.Parse(projectManager[7]) * burdenRate).ToString()));
            csv.AppendLine(marginExportLineBuilder("025,", "210,", "LABOR,", "Project Manager,", "EACH,", (decimal.Parse(projectManager[3]) - (decimal.Parse(projectManager[7]) * burdenRate)).ToString()));
            csv.AppendLine(marginExportLineBuilder("030,", "280,", "LABBURDEN,", "Program Manager,", "LS,", (decimal.Parse(programManager[7]) * burdenRate).ToString()));
            csv.AppendLine(marginExportLineBuilder("030,", "280,", "LABOR,", "Program Manager,", "EACH,", (decimal.Parse(programManager[3]) - (decimal.Parse(programManager[7]) * burdenRate)).ToString()));

            decimal testNum6 = (decimal.Parse(estimating[3]) / engineeringRate) * burdenRate;
            testNum6 = Math.Round(testNum6, 2, MidpointRounding.AwayFromZero);
            csv.AppendLine(marginExportLineBuilder("035,", "399,", "LABBURDEN,", "Estimating,", "LS,", testNum6.ToString()));

            testNum6 = decimal.Parse(estimating[3]) - ((decimal.Parse(estimating[3]) / engineeringRate) * burdenRate);
            testNum6 = Math.Round(testNum6, 2, MidpointRounding.AwayFromZero);
            csv.AppendLine(marginExportLineBuilder("035,", "399,", "LABOR,", "Estimating,", "EACH,", testNum6.ToString()));

            csv.AppendLine(marginExportLineBuilder("040,", "300,", "LABBURDEN,", "Engineering,", "LS,", (decimal.Parse(engineering2[7]) * burdenRate).ToString()));
            csv.AppendLine(marginExportLineBuilder("040,", "300,", "LABOR,", "Engineering,", "EACH,", (decimal.Parse(engineering2[3]) - (decimal.Parse(engineering2[7]) * burdenRate)).ToString()));

            csv.AppendLine(marginExportLineBuilder("042,", "320,", "LABBURDEN,", "Programming,", "LS,", (decimal.Parse(programming2[7]) * burdenRate).ToString()));
            csv.AppendLine(marginExportLineBuilder("042,", "320,", "LABOR,", "Programming,", "EACH,", (decimal.Parse(programming2[3]) - (decimal.Parse(programming2[7]) * burdenRate)).ToString()));

            csv.AppendLine(marginExportLineBuilder("045,", "380,", "LABBURDEN,", "Administration,", "LS,", decimal.Parse(admin[3]).ToString()));
            csv.AppendLine(marginExportLineBuilder("045,", "380,", "LABOR,", "Administration (Maintenance Placeholder),", "EACH,", ""));

            csv.AppendLine(marginExportLineBuilder("050,", "400,", "SUBCON,", "Subcontractor,", "LS,", decimal.Parse(installSub[3]).ToString()));
            csv.AppendLine(marginExportLineBuilder("055,", "410,", "SUBCON,", "Electrical Subcontractor (Sub #1),", "LS,", ""));

            //***********************Put these back in
            //newLine = string.Format("070," + "430," + "SUBCON," + "Mechanical Subcontractor," + "1," + "LS," + ""); //Done
            //csv.AppendLine(newLine);
            //newLine = string.Format("080," + "470," + "SUBCON," + "Other Subcontractor," + "1," + "LS," + ""); //Done
            //csv.AppendLine(newLine);

            csv.AppendLine(marginExportLineBuilder("090,", "500,", "OTHER,", "Facilities/Tools/Misc - Specific to job,", "LS,", ""));

            if (cbMilesToInstall.Checked == true)
            {
                csv.AppendLine(marginExportLineBuilder("095,", "510,", "OTHER,", "Mileage,", "EACH,", ""));
            }
            else
            {
                csv.AppendLine(marginExportLineBuilder("095,", "510,", "OTHER,", "Mileage,", "EACH,", decimal.Parse(mileage[3]).ToString()));
            }

            csv.AppendLine(marginExportLineBuilder("100,", "520,", "OTHER,", "Allowance in Material,", "EACH,", ""));
            csv.AppendLine(marginExportLineBuilder("105,", "540,", "OTHER,", "Owner Contingency,", "LS,", ""));
            csv.AppendLine(marginExportLineBuilder("110,", "570,", "OTHER,", "Sales Tax,", "EACH,", decimal.Parse(taxes[3]).ToString()));
            csv.AppendLine(marginExportLineBuilder("115,", "580,", "OTHER,", "Bond Cost,", "LS,", ""));
            csv.AppendLine(marginExportLineBuilder("120,", "600,", "OTHER,", "Warranty,", "LS,", decimal.Parse(warranty[3]).ToString()));
            csv.AppendLine(marginExportLineBuilder("125,", "700,", "OTHER,", "Risk,", "LS,", decimal.Parse(risk[3]).ToString()));

            //newLine = string.Format("020," + "200," + "LABBURDEN," + "Technician/Field Labor," + "EACH," + ((decimal.Parse(install[3]) + decimal.Parse(mileage[3])) - (decimal.Parse(install[7]) + decimal.Parse(mileage[7])) * burdenAmount));
            //csv.AppendLine(newLine);
            //newLine = string.Format("020," + "200," + "LABBURDEN," + "Technician/Field Labor," + "EACH," + ((decimal.Parse(install[3]) + decimal.Parse(mileage[3])) - (decimal.Parse(install[7]) + decimal.Parse(mileage[7])) * burdenAmount));
            //csv.AppendLine(newLine);

            //after your loop
            try
            {
                File.WriteAllText(filePath, csv.ToString());
                title = "Margin Export Complete";
                message = "The .csv file has been exported and is ready to be imported into Cost Budget tab as the Project Tasks.\n\nWould like to open the folder where the file was created?";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", selectedFolder);
                    }
                }
                catch
                {
                    MessageBox.Show("Sorry, your folder was not able to be opened.", "Error");
                }
            }
            catch
            {
                title = "Export Error";
                message = "The .csv file was not able to be created.";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            File.WriteAllText(filePath, csv.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(workingRectangle.Width), Convert.ToInt32(workingRectangle.Height));
            this.Location = new System.Drawing.Point(0, 0);


        }

        private void cbMilesToInstall_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}