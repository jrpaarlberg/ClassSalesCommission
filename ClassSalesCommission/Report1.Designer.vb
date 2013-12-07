Partial Class Report1
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report1))
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.sales_dtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_inv_idCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_nbrCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_descCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_initial_purchase_dtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cust_item_yrsCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_qtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_costCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_priceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_markup_pctCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_comm_pctCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_comm_amCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_rep_assoc_nmGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.sales_rep_assoc_nmGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.cust_nmGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.sales_item_qtySumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_item_costSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_item_priceSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_comm_amSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.cust_nmGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.cust_nmDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.sales_dtCountFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.sales_item_qtySumFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.sales_item_costSumFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.sales_item_priceSumFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.sales_comm_amSumFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.sales_dtDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_inv_idDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_nbrDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_descDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_initial_purchase_dtDataTextBox = New Telerik.Reporting.TextBox()
        Me.cust_item_yrsDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_costDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_priceDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_markup_pctDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_comm_pctDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_comm_amDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.16892719268798828R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_dtCaptionTextBox, Me.sales_inv_idCaptionTextBox, Me.item_nbrCaptionTextBox, Me.item_descCaptionTextBox, Me.item_initial_purchase_dtCaptionTextBox, Me.cust_item_yrsCaptionTextBox, Me.sales_item_qtyCaptionTextBox, Me.sales_item_costCaptionTextBox, Me.sales_item_priceCaptionTextBox, Me.sales_markup_pctCaptionTextBox, Me.sales_comm_pctCaptionTextBox, Me.sales_comm_amCaptionTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'sales_dtCaptionTextBox
        '
        Me.sales_dtCaptionTextBox.CanGrow = True
        Me.sales_dtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0729166641831398R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_dtCaptionTextBox.Name = "sales_dtCaptionTextBox"
        Me.sales_dtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70974290370941162R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_dtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_dtCaptionTextBox.StyleName = "Caption"
        Me.sales_dtCaptionTextBox.Value = "Sales Date" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'sales_inv_idCaptionTextBox
        '
        Me.sales_inv_idCaptionTextBox.CanGrow = True
        Me.sales_inv_idCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.782738208770752R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_inv_idCaptionTextBox.Name = "sales_inv_idCaptionTextBox"
        Me.sales_inv_idCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70974260568618774R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_inv_idCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_inv_idCaptionTextBox.StyleName = "Caption"
        Me.sales_inv_idCaptionTextBox.Value = "Invoice"
        '
        'item_nbrCaptionTextBox
        '
        Me.item_nbrCaptionTextBox.CanGrow = True
        Me.item_nbrCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.492559552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.item_nbrCaptionTextBox.Name = "item_nbrCaptionTextBox"
        Me.item_nbrCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2072827816009521R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_nbrCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_nbrCaptionTextBox.StyleName = "Caption"
        Me.item_nbrCaptionTextBox.Value = "Item Number"
        '
        'item_descCaptionTextBox
        '
        Me.item_descCaptionTextBox.CanGrow = True
        Me.item_descCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6999213695526123R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_descCaptionTextBox.Name = "item_descCaptionTextBox"
        Me.item_descCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3115277290344238R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_descCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_descCaptionTextBox.StyleName = "Caption"
        Me.item_descCaptionTextBox.Value = "Item Description"
        '
        'item_initial_purchase_dtCaptionTextBox
        '
        Me.item_initial_purchase_dtCaptionTextBox.CanGrow = True
        Me.item_initial_purchase_dtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0115280151367188R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_initial_purchase_dtCaptionTextBox.Name = "item_initial_purchase_dtCaptionTextBox"
        Me.item_initial_purchase_dtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_initial_purchase_dtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_initial_purchase_dtCaptionTextBox.StyleName = "Caption"
        Me.item_initial_purchase_dtCaptionTextBox.Value = "Initial Purchase"
        '
        'cust_item_yrsCaptionTextBox
        '
        Me.cust_item_yrsCaptionTextBox.CanGrow = True
        Me.cust_item_yrsCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7005963325500488R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.cust_item_yrsCaptionTextBox.Name = "cust_item_yrsCaptionTextBox"
        Me.cust_item_yrsCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49932453036308289R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.cust_item_yrsCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cust_item_yrsCaptionTextBox.StyleName = "Caption"
        Me.cust_item_yrsCaptionTextBox.Value = "Cust Years"
        '
        'sales_item_qtyCaptionTextBox
        '
        Me.sales_item_qtyCaptionTextBox.CanGrow = True
        Me.sales_item_qtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_item_qtyCaptionTextBox.Name = "sales_item_qtyCaptionTextBox"
        Me.sales_item_qtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7097432017326355R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_item_qtyCaptionTextBox.StyleName = "Caption"
        Me.sales_item_qtyCaptionTextBox.Value = "Ship Qty"
        '
        'sales_item_costCaptionTextBox
        '
        Me.sales_item_costCaptionTextBox.CanGrow = True
        Me.sales_item_costCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.9098224639892578R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_item_costCaptionTextBox.Name = "sales_item_costCaptionTextBox"
        Me.sales_item_costCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.73049646615982056R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_costCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_item_costCaptionTextBox.StyleName = "Caption"
        Me.sales_item_costCaptionTextBox.Value = "Total Cost"
        '
        'sales_item_priceCaptionTextBox
        '
        Me.sales_item_priceCaptionTextBox.CanGrow = True
        Me.sales_item_priceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6403975486755371R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_item_priceCaptionTextBox.Name = "sales_item_priceCaptionTextBox"
        Me.sales_item_priceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_priceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_item_priceCaptionTextBox.StyleName = "Caption"
        Me.sales_item_priceCaptionTextBox.Value = "Total Price"
        '
        'sales_markup_pctCaptionTextBox
        '
        Me.sales_markup_pctCaptionTextBox.CanGrow = True
        Me.sales_markup_pctCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.32946491241455R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_markup_pctCaptionTextBox.Name = "sales_markup_pctCaptionTextBox"
        Me.sales_markup_pctCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70974260568618774R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_markup_pctCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_markup_pctCaptionTextBox.StyleName = "Caption"
        Me.sales_markup_pctCaptionTextBox.Value = "Mark Up"
        '
        'sales_comm_pctCaptionTextBox
        '
        Me.sales_comm_pctCaptionTextBox.CanGrow = True
        Me.sales_comm_pctCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0392866134643555R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_comm_pctCaptionTextBox.Name = "sales_comm_pctCaptionTextBox"
        Me.sales_comm_pctCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7097432017326355R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_pctCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_comm_pctCaptionTextBox.StyleName = "Caption"
        Me.sales_comm_pctCaptionTextBox.Value = "Comm Pct"
        '
        'sales_comm_amCaptionTextBox
        '
        Me.sales_comm_amCaptionTextBox.CanGrow = True
        Me.sales_comm_amCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.74910831451416R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_comm_amCaptionTextBox.Name = "sales_comm_amCaptionTextBox"
        Me.sales_comm_amCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_amCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_comm_amCaptionTextBox.StyleName = "Caption"
        Me.sales_comm_amCaptionTextBox.Value = "Comm Amt"
        '
        'sales_rep_assoc_nmGroupFooterSection
        '
        Me.sales_rep_assoc_nmGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.sales_rep_assoc_nmGroupFooterSection.Name = "sales_rep_assoc_nmGroupFooterSection"
        '
        'sales_rep_assoc_nmGroupHeaderSection
        '
        Me.sales_rep_assoc_nmGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.sales_rep_assoc_nmGroupHeaderSection.Name = "sales_rep_assoc_nmGroupHeaderSection"
        '
        'cust_nmGroupFooterSection
        '
        Me.cust_nmGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.462421178817749R)
        Me.cust_nmGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_item_qtySumFunctionTextBox1, Me.sales_item_costSumFunctionTextBox1, Me.sales_item_priceSumFunctionTextBox1, Me.sales_comm_amSumFunctionTextBox1, Me.TextBox5, Me.TextBox6})
        Me.cust_nmGroupFooterSection.Name = "cust_nmGroupFooterSection"
        Me.cust_nmGroupFooterSection.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cust_nmGroupFooterSection.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        '
        'sales_item_qtySumFunctionTextBox1
        '
        Me.sales_item_qtySumFunctionTextBox1.CanGrow = True
        Me.sales_item_qtySumFunctionTextBox1.Format = "{0:N0}"
        Me.sales_item_qtySumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtySumFunctionTextBox1.Name = "sales_item_qtySumFunctionTextBox1"
        Me.sales_item_qtySumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_qtySumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtySumFunctionTextBox1.StyleName = "Data"
        Me.sales_item_qtySumFunctionTextBox1.Value = "=Sum(Fields.sales_item_qty)"
        '
        'sales_item_costSumFunctionTextBox1
        '
        Me.sales_item_costSumFunctionTextBox1.CanGrow = True
        Me.sales_item_costSumFunctionTextBox1.Format = "{0:N2}"
        Me.sales_item_costSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.909822940826416R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_costSumFunctionTextBox1.Name = "sales_item_costSumFunctionTextBox1"
        Me.sales_item_costSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_costSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_costSumFunctionTextBox1.StyleName = "Data"
        Me.sales_item_costSumFunctionTextBox1.Value = "=Sum(Fields.sales_item_cost)* Fields.sales_item_qty"
        '
        'sales_item_priceSumFunctionTextBox1
        '
        Me.sales_item_priceSumFunctionTextBox1.CanGrow = True
        Me.sales_item_priceSumFunctionTextBox1.Format = "{0:N2}"
        Me.sales_item_priceSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6196441650390625R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_priceSumFunctionTextBox1.Name = "sales_item_priceSumFunctionTextBox1"
        Me.sales_item_priceSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_priceSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_priceSumFunctionTextBox1.StyleName = "Data"
        Me.sales_item_priceSumFunctionTextBox1.Value = "=Sum(Fields.sales_item_price)* Fields.sales_item_qty"
        '
        'sales_comm_amSumFunctionTextBox1
        '
        Me.sales_comm_amSumFunctionTextBox1.CanGrow = True
        Me.sales_comm_amSumFunctionTextBox1.Format = "{0:N2}"
        Me.sales_comm_amSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.710972785949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_comm_amSumFunctionTextBox1.Name = "sales_comm_amSumFunctionTextBox1"
        Me.sales_comm_amSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_amSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_comm_amSumFunctionTextBox1.StyleName = "Data"
        Me.sales_comm_amSumFunctionTextBox1.Value = "=Sum(Fields.sales_comm_am)"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0729166641831398R), Telerik.Reporting.Drawing.Unit.Inch(0.024363517761230469R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3988097906112671R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "Customer Total for:"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.024363517761230469R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3458335399627686R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "=Fields.cust_nm"
        '
        'cust_nmGroupHeaderSection
        '
        Me.cust_nmGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.462421178817749R)
        Me.cust_nmGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.cust_nmDataTextBox, Me.TextBox4})
        Me.cust_nmGroupHeaderSection.Name = "cust_nmGroupHeaderSection"
        '
        'cust_nmDataTextBox
        '
        Me.cust_nmDataTextBox.CanGrow = True
        Me.cust_nmDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.cust_nmDataTextBox.Name = "cust_nmDataTextBox"
        Me.cust_nmDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3410713672637939R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.cust_nmDataTextBox.Style.Font.Bold = True
        Me.cust_nmDataTextBox.StyleName = "Data"
        Me.cust_nmDataTextBox.Value = "=Fields.cust_nm"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0729166641831398R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3988097906112671R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "=Fields.cust_nbr"
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "ClassSalesCommission.My.MySettings.ConvTest"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = "Select DISTINCT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "sales_rep_assoc_nm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         dwh_sales_detail " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "ClassSalesCommission.My.MySettings.ConvTest"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@SalesRepName", System.Data.DbType.[String], "=Parameters.SalesRepName.Value")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_dtCountFunctionTextBox2, Me.sales_item_qtySumFunctionTextBox2, Me.sales_item_costSumFunctionTextBox2, Me.sales_item_priceSumFunctionTextBox2, Me.sales_comm_amSumFunctionTextBox2, Me.TextBox1})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'sales_dtCountFunctionTextBox2
        '
        Me.sales_dtCountFunctionTextBox2.CanGrow = True
        Me.sales_dtCountFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4404761791229248R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.sales_dtCountFunctionTextBox2.Name = "sales_dtCountFunctionTextBox2"
        Me.sales_dtCountFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_dtCountFunctionTextBox2.StyleName = "Data"
        Me.sales_dtCountFunctionTextBox2.Value = "=Count(Fields.sales_dt)"
        '
        'sales_item_qtySumFunctionTextBox2
        '
        Me.sales_item_qtySumFunctionTextBox2.CanGrow = True
        Me.sales_item_qtySumFunctionTextBox2.Format = "{0:N0}"
        Me.sales_item_qtySumFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtySumFunctionTextBox2.Name = "sales_item_qtySumFunctionTextBox2"
        Me.sales_item_qtySumFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_qtySumFunctionTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtySumFunctionTextBox2.StyleName = "Data"
        Me.sales_item_qtySumFunctionTextBox2.Value = "=Sum(Fields.sales_item_qty)"
        '
        'sales_item_costSumFunctionTextBox2
        '
        Me.sales_item_costSumFunctionTextBox2.CanGrow = True
        Me.sales_item_costSumFunctionTextBox2.Format = "{0:N2}"
        Me.sales_item_costSumFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.909822940826416R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_costSumFunctionTextBox2.Name = "sales_item_costSumFunctionTextBox2"
        Me.sales_item_costSumFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_costSumFunctionTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_costSumFunctionTextBox2.StyleName = "Data"
        Me.sales_item_costSumFunctionTextBox2.Value = "=Sum(Fields.sales_item_cost)"
        '
        'sales_item_priceSumFunctionTextBox2
        '
        Me.sales_item_priceSumFunctionTextBox2.CanGrow = True
        Me.sales_item_priceSumFunctionTextBox2.Format = "{0:N2}"
        Me.sales_item_priceSumFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6196441650390625R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_priceSumFunctionTextBox2.Name = "sales_item_priceSumFunctionTextBox2"
        Me.sales_item_priceSumFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_priceSumFunctionTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_priceSumFunctionTextBox2.StyleName = "Data"
        Me.sales_item_priceSumFunctionTextBox2.Value = "=Sum(Fields.sales_item_price)"
        '
        'sales_comm_amSumFunctionTextBox2
        '
        Me.sales_comm_amSumFunctionTextBox2.CanGrow = True
        Me.sales_comm_amSumFunctionTextBox2.Format = "{0:N2}"
        Me.sales_comm_amSumFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.710972785949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_comm_amSumFunctionTextBox2.Name = "sales_comm_amSumFunctionTextBox2"
        Me.sales_comm_amSumFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_amSumFunctionTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_comm_amSumFunctionTextBox2.StyleName = "Data"
        Me.sales_comm_amSumFunctionTextBox2.Value = "=Sum(Fields.sales_comm_am)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.041587192565202713R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3988097906112671R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "Grand Total:"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.099999994039535522R)
        Me.pageHeader.Name = "pageHeader"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9895834922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0583333969116211R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.TextBox2, Me.TextBox7, Me.PictureBox1})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6999213695526123R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8999998569488525R), Telerik.Reporting.Drawing.Unit.Inch(0.35833334922790527R))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Navy
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Sales Commission Report"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.35841202735900879R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.32918620109558105R))
        Me.TextBox2.Style.Color = System.Drawing.Color.Navy
        Me.TextBox2.StyleName = "Title"
        Me.TextBox2.Value = "=""For Dates  "" + Format(""{0:MM/dd/yyyy}"",Parameters.StartDate.Value.Date) + "" to " & _
    """ + Format(""{0:MM/dd/yyyy}"",Parameters.EndDate.Value.Date) "
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4883925914764404R), Telerik.Reporting.Drawing.Unit.Inch(0.68767696619033813R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8999998569488525R), Telerik.Reporting.Drawing.Unit.Inch(0.27924546599388123R))
        Me.TextBox7.Style.Color = System.Drawing.Color.Navy
        Me.TextBox7.StyleName = "Title"
        Me.TextBox7.Value = "=""Salesman: "" + Parameters.SalesRepName.Value"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Inch(0.16692249476909637R))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'detail
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("RowNumber()%2", Telerik.Reporting.FilterOperator.Equal, "1"))
        FormattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_dtDataTextBox, Me.sales_inv_idDataTextBox, Me.item_nbrDataTextBox, Me.item_descDataTextBox, Me.item_initial_purchase_dtDataTextBox, Me.cust_item_yrsDataTextBox, Me.sales_item_qtyDataTextBox, Me.sales_item_costDataTextBox, Me.sales_item_priceDataTextBox, Me.sales_markup_pctDataTextBox, Me.sales_comm_pctDataTextBox, Me.sales_comm_amDataTextBox})
        Me.detail.Name = "detail"
        '
        'sales_dtDataTextBox
        '
        Me.sales_dtDataTextBox.CanGrow = True
        Me.sales_dtDataTextBox.Format = "{0:d}"
        Me.sales_dtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0729166641831398R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_dtDataTextBox.Name = "sales_dtDataTextBox"
        Me.sales_dtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_dtDataTextBox.StyleName = "Data"
        Me.sales_dtDataTextBox.Value = "=Fields.sales_dt"
        '
        'sales_inv_idDataTextBox
        '
        Me.sales_inv_idDataTextBox.CanGrow = True
        Me.sales_inv_idDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.782738208770752R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_inv_idDataTextBox.Name = "sales_inv_idDataTextBox"
        Me.sales_inv_idDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_inv_idDataTextBox.StyleName = "Data"
        Me.sales_inv_idDataTextBox.Value = "=Fields.sales_inv_id"
        '
        'item_nbrDataTextBox
        '
        Me.item_nbrDataTextBox.CanGrow = True
        Me.item_nbrDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.492559552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.item_nbrDataTextBox.Name = "item_nbrDataTextBox"
        Me.item_nbrDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1074403524398804R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_nbrDataTextBox.StyleName = "Data"
        Me.item_nbrDataTextBox.Value = "=Fields.item_nbr"
        '
        'item_descDataTextBox
        '
        Me.item_descDataTextBox.CanGrow = True
        Me.item_descDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6602776050567627R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.item_descDataTextBox.Name = "item_descDataTextBox"
        Me.item_descDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3292267322540283R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_descDataTextBox.StyleName = "Data"
        Me.item_descDataTextBox.Value = "=Fields.item_desc"
        '
        'item_initial_purchase_dtDataTextBox
        '
        Me.item_initial_purchase_dtDataTextBox.CanGrow = True
        Me.item_initial_purchase_dtDataTextBox.Format = "{0:d}"
        Me.item_initial_purchase_dtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9895834922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.item_initial_purchase_dtDataTextBox.Name = "item_initial_purchase_dtDataTextBox"
        Me.item_initial_purchase_dtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.item_initial_purchase_dtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.item_initial_purchase_dtDataTextBox.StyleName = "Data"
        Me.item_initial_purchase_dtDataTextBox.Value = "=Fields.item_initial_purchase_dt"
        '
        'cust_item_yrsDataTextBox
        '
        Me.cust_item_yrsDataTextBox.CanGrow = True
        Me.cust_item_yrsDataTextBox.Format = "{0:N0}"
        Me.cust_item_yrsDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7005963325500488R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.cust_item_yrsDataTextBox.Name = "cust_item_yrsDataTextBox"
        Me.cust_item_yrsDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47857129573822021R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.cust_item_yrsDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.cust_item_yrsDataTextBox.StyleName = "Data"
        Me.cust_item_yrsDataTextBox.Value = "=Fields.cust_item_yrs"
        '
        'sales_item_qtyDataTextBox
        '
        Me.sales_item_qtyDataTextBox.CanGrow = True
        Me.sales_item_qtyDataTextBox.Format = "{0:N0}"
        Me.sales_item_qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtyDataTextBox.Name = "sales_item_qtyDataTextBox"
        Me.sales_item_qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtyDataTextBox.StyleName = "Data"
        Me.sales_item_qtyDataTextBox.Value = "=Fields.sales_item_qty"
        '
        'sales_item_costDataTextBox
        '
        Me.sales_item_costDataTextBox.CanGrow = True
        Me.sales_item_costDataTextBox.Format = "{0:N2}"
        Me.sales_item_costDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.909822940826416R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_costDataTextBox.Name = "sales_item_costDataTextBox"
        Me.sales_item_costDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_costDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_costDataTextBox.StyleName = "Data"
        Me.sales_item_costDataTextBox.Value = "=Fields.sales_item_cost* Fields.sales_item_qty"
        '
        'sales_item_priceDataTextBox
        '
        Me.sales_item_priceDataTextBox.CanGrow = True
        Me.sales_item_priceDataTextBox.Format = "{0:N2}"
        Me.sales_item_priceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6196441650390625R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_priceDataTextBox.Name = "sales_item_priceDataTextBox"
        Me.sales_item_priceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_priceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_priceDataTextBox.StyleName = "Data"
        Me.sales_item_priceDataTextBox.Value = "=Fields.sales_item_price* Fields.sales_item_qty"
        '
        'sales_markup_pctDataTextBox
        '
        Me.sales_markup_pctDataTextBox.CanGrow = True
        Me.sales_markup_pctDataTextBox.Format = "{0:P2}"
        Me.sales_markup_pctDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.32946491241455R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_markup_pctDataTextBox.Name = "sales_markup_pctDataTextBox"
        Me.sales_markup_pctDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_markup_pctDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_markup_pctDataTextBox.StyleName = "Data"
        Me.sales_markup_pctDataTextBox.Value = "=Fields.sales_markup_pct"
        '
        'sales_comm_pctDataTextBox
        '
        Me.sales_comm_pctDataTextBox.CanGrow = True
        Me.sales_comm_pctDataTextBox.Format = "{0:P2}"
        Me.sales_comm_pctDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0392866134643555R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_comm_pctDataTextBox.Name = "sales_comm_pctDataTextBox"
        Me.sales_comm_pctDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_pctDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_comm_pctDataTextBox.StyleName = "Data"
        Me.sales_comm_pctDataTextBox.Value = "=Fields.sales_comm_pct"
        '
        'sales_comm_amDataTextBox
        '
        Me.sales_comm_amDataTextBox.CanGrow = True
        Me.sales_comm_amDataTextBox.Format = "{0:N2}"
        Me.sales_comm_amDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.710972785949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_comm_amDataTextBox.Name = "sales_comm_amDataTextBox"
        Me.sales_comm_amDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6889880895614624R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_comm_amDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_comm_amDataTextBox.StyleName = "Data"
        Me.sales_comm_amDataTextBox.Value = "=Fields.sales_comm_am"
        '
        'Report1
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.LessOrEqual, "=Parameters.EndDate.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=Parameters.StartDate.Value"))
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.sales_rep_assoc_nmGroupFooterSection
        Group2.GroupHeader = Me.sales_rep_assoc_nmGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.sales_rep_assoc_nm"))
        Group2.Name = "sales_rep_assoc_nmGroup"
        Group3.GroupFooter = Me.cust_nmGroupFooterSection
        Group3.GroupHeader = Me.cust_nmGroupHeaderSection
        Group3.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.cust_nm"))
        Group3.Name = "cust_nmGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.sales_rep_assoc_nmGroupHeaderSection, Me.sales_rep_assoc_nmGroupFooterSection, Me.cust_nmGroupHeaderSection, Me.cust_nmGroupFooterSection, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.Name = "Report1"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.AllowBlank = False
        ReportParameter1.Name = "StartDate"
        ReportParameter1.Text = "Start Date"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = "=now()"
        ReportParameter1.Visible = True
        ReportParameter2.AllowBlank = False
        ReportParameter2.Name = "EndDate"
        ReportParameter2.Text = "End Date"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = "=now()"
        ReportParameter2.Visible = True
        ReportParameter3.AvailableValues.DataSource = Me.SqlDataSource2
        ReportParameter3.AvailableValues.DisplayMember = "= Fields.sales_rep_assoc_nm"
        ReportParameter3.AvailableValues.ValueMember = "= Fields.sales_rep_assoc_nm"
        ReportParameter3.Name = "SalesRepName"
        ReportParameter3.Text = "SalesRepName"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(74, Byte), Integer))
        StyleRule1.Style.Font.Name = "Georgia"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(173, Byte), Integer))
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(212, Byte), Integer))
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        StyleRule2.Style.Font.Name = "Georgia"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Georgia"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Georgia"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_dtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_inv_idCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_nbrCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_descCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_initial_purchase_dtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cust_item_yrsCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_markup_pctCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_pctCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_amCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents sales_rep_assoc_nmGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_rep_assoc_nmGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents cust_nmGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cust_nmDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cust_nmGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents sales_item_qtySumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_amSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents sales_dtCountFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtySumFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costSumFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceSumFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_amSumFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents sales_dtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_inv_idDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_nbrDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_descDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_initial_purchase_dtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cust_item_yrsDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_markup_pctDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_pctDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_comm_amDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
End Class