using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using CMD.Payan.Base.Common;
using PayanarSSControls = Payanar.SS.Net.Libraries.Views.CustomControls;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using CMD.Payan.Base.Views.CustomControls;

namespace CMD.Payan.Hrms.Views
{
    public partial class MenuExplorerView : TreeViewControl
    {
        public MenuExplorerView()
            : base()
        {
            InitializeComponent();
            Title = "MENU";
        }

        public MenuExplorerView(IObserver observer)
        {
            AddObserver(observer);
            InitializeComponent();
            Title = "MENU";
        }

        public override void LoadDatas()
        {
            AddMenuItems();
            treeView.ExpandAll();
        }

        protected override void OnNodeMouseDoubleClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            base.OnNodeMouseDoubleClick(sender, e);

            PayanarSSControls.TreeNode treeNode = (e.Node as PayanarSSControls.TreeNode);

            treeNode.CreateView();
            NotifyObserver(treeNode.ViewDetails, "OpenView");
        }

        private void AddMenuItems()
        {
            // Root Node
            PayanarSSControls.TreeNode rootTreeNode = AddNode("Menus", "Menus");
            ////PayanarSSControls.TreeNode bankRootTreeNode = AddNode("Bank Details", "Bank Details");
            ////PayanarSSControls.TreeNode commonRootTreeNode = AddNode("Common", "Common");
            ////PayanarSSControls.TreeNode mesRootTreeNode = AddNode("Payanar.SS", "Payanar.SS");
            ////PayanarSSControls.TreeNode chittyRootTreeNode = AddNode("Chitty", "Chitty");

            // Payanar.SS
            PayanarSSControls.TreeNode mastersTreeNode = AddNode(rootTreeNode, "Hrms", "Hrms");
            ////PayanarSSControls.TreeNode mesTransactionsTreeNode = AddNode(mesRootTreeNode, "Transactions", "Transactions");

            ////// Chitty
            ////PayanarSSControls.TreeNode chittyHrmsTreeNode = AddNode(chittyRootTreeNode, "Hrms", "Hrms");
            ////PayanarSSControls.TreeNode chittyTransactionsTreeNode = AddNode(chittyRootTreeNode, "Transactions", "Transactions");

            ////// Bank Details
            ////PayanarSSControls.TreeNode bankNode = AddNode(bankRootTreeNode, "Banks", "Banks", BankCollectionViewFactory.Factory, ViewContext.Create("Banks", "Banks", "Banks"));
            ////////PayanarSSControls.TreeNode bankShareDetailsNode = AddNode(bankNode, "Bank Share Details", "Bank Share Details", BankShareDetailsCollectionViewFactory.Factory, ViewContext.Create("Bank Share Details", "Bank Share Details", "Bank Share Details"));
            ////PayanarSSControls.TreeNode boardDesignationNode = AddNode(bankRootTreeNode, "Board Designations", "Board Designations", BoardDesignationCollectionViewFactory.Factory, ViewContext.Create("Board Designations", "Board Designations", "Board Designations"));
            ////PayanarSSControls.TreeNode boardDetailNode = AddNode(bankRootTreeNode, "Board Details", "Board Details", BoardDetailCollectionViewFactory.Factory, ViewContext.Create("Board Details", "Board Details", "Board Details"));
            ////////PayanarSSControls.TreeNode boardMembershipDetailsNode = AddNode(boardDetailNode, "Board Membership Details", "Board Membership Details", BoardMembershipDetailsCollectionViewFactory.Factory, ViewContext.Create("Board Membership Details", "Board Membership Details", "Board Membership Details"));
            ////PayanarSSControls.TreeNode staffMasterNode = AddNode(bankRootTreeNode, "Staff Hrms", "Staff Hrms", StaffMasterCollectionViewFactory.Factory, ViewContext.Create("Staff Hrms", "Staff Hrms", "Staff Hrms"));

            ////// Common Hrms
            ////PayanarSSControls.TreeNode contactTypeNode = AddNode(commonRootTreeNode, "Contact Types", "Contact Types", ContactTypeCollectionViewFactory.Factory, ViewContext.Create("Contact Types", "Contact Types", "Contact Types"));
            ////PayanarSSControls.TreeNode casteCategoriesNode = AddNode(commonRootTreeNode, "Caste Categories", "Caste Categories", CasteCategoryCollectionViewFactory.Factory, ViewContext.Create("Caste Categories", "Caste Categories", "Caste Categories"));
            ////PayanarSSControls.TreeNode casteNode = AddNode(commonRootTreeNode, "Castes", "Castes", CasteCollectionViewFactory.Factory, ViewContext.Create("Castes", "Castes", "Castes"));
            ////PayanarSSControls.TreeNode designationsNode = AddNode(commonRootTreeNode, "Designations", "Designations", DesignationCollectionViewFactory.Factory, ViewContext.Create("Designations", "Designations", "Designations"));
            ////PayanarSSControls.TreeNode genderNode = AddNode(commonRootTreeNode, "Genders", "Genders", GenderCollectionViewFactory.Factory, ViewContext.Create("Genders", "Genders", "Genders"));
            ////PayanarSSControls.TreeNode memberTypeNode = AddNode(commonRootTreeNode, "Member Types", "Member Types", MemberTypeCollectionViewFactory.Factory, ViewContext.Create("Member Types", "Member Types", "Member Types"));
            ////PayanarSSControls.TreeNode religionsNode = AddNode(commonRootTreeNode, "Religions", "Religions", ReligionCollectionViewFactory.Factory, ViewContext.Create("Religions", "Religions", "Religions"));
            ////PayanarSSControls.TreeNode memberNode = AddNode(commonRootTreeNode, "Members", "Members", MemberCollectionViewFactory.Factory, ViewContext.Create("Members", "Members", "Members"));
            ////////PayanarSSControls.TreeNode memberNominationMappingNode = AddNode(memberNode, "Member Nomination Mappings", "Member Nomination Mappings", MemberNominationMappingCollectionViewFactory.Factory, ViewContext.Create("Member Nomination Mappings", "Member Nomination Mappings", "Member Nomination Mappings"));
            ////////PayanarSSControls.TreeNode memberGuardianMappingNode = AddNode(memberNode, "Member Guardian Mappings", "Member Guardian Mappings", MemberGuardianMappingCollectionViewFactory.Factory, ViewContext.Create("Member Guardian Mappings", "Member Guardian Mappings", "Member Guardian Mappings"));
            ////////PayanarSSControls.TreeNode memberServiceDetailsNode = AddNode(memberNode, "Member Service Details", "Member Service Details", MemberServiceDetailsCollectionViewFactory.Factory, ViewContext.Create("Member Service Details", "Member Service Details", "Member Service Details"));
            ////////PayanarSSControls.TreeNode OtherSocietyMembershipDetailsNode = AddNode(memberNode, "Other Society Membership Details", "Other Society Membership Details", OtherSocietyMembershipDetailsCollectionViewFactory.Factory, ViewContext.Create("Other Society Membership Details", "Other Society Membership Details", "Other Society Membership Details"));
            ////////PayanarSSControls.TreeNode memberWitnessDetailsMappingNode = AddNode(memberNode, "Member Witness Details Mapping", "Member Witness Details Mapping", MemberWitnessDetailsMappingCollectionViewFactory.Factory, ViewContext.Create("Member Witness Details Mapping", "Member Witness Details Mapping", "Member Witness Details Mapping"));
            ////////PayanarSSControls.TreeNode memberTransferDetailsNode = AddNode(memberNode, "Member Transfer Details", "Member Transfer Details", MemberTransferDetailsCollectionViewFactory.Factory, ViewContext.Create("Member Transfer Details", "Member Transfer Details", "Member Transfer Details"));
            ////////PayanarSSControls.TreeNode memberContactMappingNode = AddNode(memberNode, "Member Contacts Mapping", "Member Contacts Mapping", MemberContactMappingCollectionViewFactory.Factory, ViewContext.Create("Member Contacts Mapping", "Member Contacts Mapping", "Member Contacts Mapping"));
            ////PayanarSSControls.TreeNode memberAClassNode = AddNode(commonRootTreeNode, "Member A Classes", "Member A Classes", MemberAClassCollectionViewFactory.Factory, ViewContext.Create("Member A Classes", "Member A Classes", "Member A Classes"));
            ////PayanarSSControls.TreeNode memberTransferTypeNode = AddNode(commonRootTreeNode, "Member Transfer Types", "Member Transfer Types", MemberTransferTypeCollectionViewFactory.Factory, ViewContext.Create("Member Transfer Types", "Member Transfer Types", "Member Transfer Types"));
            ////////PayanarSSControls.TreeNode memberTransferNode = AddNode(commonRootTreeNode, "Member Transfers", "Member Transfers", MemberTransferCollectionViewFactory.Factory, ViewContext.Create("Member Transfers", "Member Transfers", "Member Transfers"));
            ////PayanarSSControls.TreeNode periodUnitNode = AddNode(commonRootTreeNode, "Period Units", "Period Units", PeriodUnitCollectionViewFactory.Factory, ViewContext.Create("Period Units", "Period Units", "Period Units"));
            ////PayanarSSControls.TreeNode periodNode = AddNode(commonRootTreeNode, "Periods", "Periods", PeriodCollectionViewFactory.Factory, ViewContext.Create("Periods", "Periods", "Periods"));

            // Payanar.SS Hrms
            PayanarSSControls.TreeNode accountCategoriesNode = AddNode(mastersTreeNode, "AccessDetails", "Access Details", AccessDetailsCollectionViewFactory.Factory, ViewContext.Create("AccessDetails", "AccessDetails", "AccessDetails"));
            PayanarSSControls.TreeNode callLetterNode = AddNode(mastersTreeNode, "CallLetters", "Call Letters", CallLetterCollectionViewFactory.Factory, ViewContext.Create("CallLetters", "Call Letters", "Call Letters"));
            ////PayanarSSControls.TreeNode accountOperatedByNode = AddNode(mesHrmsTreeNode, "Accounts OperatedBy", "Accounts OperatedBy", AccountOperatedByCollectionViewFactory.Factory, ViewContext.Create("Accounts OperatedBy", "Accounts OperatedBy", "Accounts OperatedBy"));
            ////PayanarSSControls.TreeNode accountOperationTypeNode = AddNode(mesHrmsTreeNode, "Account Operation Types", "Account Operation Types", AccountOperationTypeCollectionViewFactory.Factory, ViewContext.Create("Account Operation Types", "Account Operation Types", "Account Operation Types"));
            ////PayanarSSControls.TreeNode accountTypeNode = AddNode(mesHrmsTreeNode, "Account Types", "Account Types", AccountTypeCollectionViewFactory.Factory, ViewContext.Create("Account Types", "Account Types", "Account Types"));
            ////////PayanarSSControls.TreeNode addressNode = AddNode(mastersTreeNode, "Address", "Address", AddressCollectionViewFactory.Factory, ViewContext.Create("Address", "Address", "Address"));
            ////PayanarSSControls.TreeNode citizenCategoryNode = AddNode(mesHrmsTreeNode, "Citizen Categories", "Citizen Categories", CitizenCategoryCollectionViewFactory.Factory, ViewContext.Create("Citizen Categories", "Citizen Categories", "Citizen Categories"));
            ////////PayanarSSControls.TreeNode contactNode = AddNode(mastersTreeNode, "Contacts", "Contacts", ContactCollectionViewFactory.Factory, ViewContext.Create("Contacts", "Contacts", "Contacts"));
            ////PayanarSSControls.TreeNode departmentsNode = AddNode(mesHrmsTreeNode, "Departments", "Departments", DepartmentCollectionViewFactory.Factory, ViewContext.Create("Departments", "Departments", "Departments"));
            ////PayanarSSControls.TreeNode depositTypeNode = AddNode(mesHrmsTreeNode, "Deposit Types", "Deposit Types", DepositTypeCollectionViewFactory.Factory, ViewContext.Create("Deposit Types", "Deposit Types", "Deposit Types"));
            ////PayanarSSControls.TreeNode yearlyInterestPayModeNode = AddNode(mesHrmsTreeNode, "Yearly Interest Pay Modes", "Yearly Interest Pay Modes", YearlyInterestPayModeCollectionViewFactory.Factory, ViewContext.Create("Yearly Interest Pay Modes", "Yearly Interest Pay Modes", "Yearly Interest Pay Modes"));
            ////PayanarSSControls.TreeNode depositRateNode = AddNode(mesHrmsTreeNode, "Deposit Rates", "Deposit Rates", DepositRateCollectionViewFactory.Factory, ViewContext.Create("Deposit Rates", "Deposit Rates", "Deposit Rates"));
            ////PayanarSSControls.TreeNode fASAccountHeadNode = AddNode(mesHrmsTreeNode, "FAS Accounts Head", "FAS Accounts Head", FASAccountHeadCollectionViewFactory.Factory, ViewContext.Create("FAS Accounts Head", "FAS Accounts Head", "FAS Accounts Head"));
            ////PayanarSSControls.TreeNode fixedDepositRateNode = AddNode(mesHrmsTreeNode, "Fixed Deposit Rates", "Fixed Deposit Rates", FixedDepositRateCollectionViewFactory.Factory, ViewContext.Create("Fixed Deposit Rates", "Fixed Deposit Rates", "Fixed Deposit Rates"));
            ////////PayanarSSControls.TreeNode guardianNode = AddNode(mastersTreeNode, "Guardians", "Guardians", GuardianCollectionViewFactory.Factory, ViewContext.Create("Guardians", "Guardians", "Guardians"));
            ////PayanarSSControls.TreeNode holidayHeaderNode = AddNode(mesHrmsTreeNode, "Holidays Header", "Holidays Header", HolidayHeaderCollectionViewFactory.Factory, ViewContext.Create("Holidays Header", "Holidays Header", "Holidays Header"));
            ////////PayanarSSControls.TreeNode holidayDetailsNode = AddNode(holidayHeaderNode, "Holiday Details", "Holiday Details", HolidayDetailsCollectionViewFactory.Factory, ViewContext.Create("Holiday Details", "Holiday Details", "Holiday Details"));
            ////PayanarSSControls.TreeNode loanSchemeTypeNode = AddNode(mesHrmsTreeNode, "Loan Scheme Types", "Loan Scheme Types", LoanSchemeTypeCollectionViewFactory.Factory, ViewContext.Create("Loan Scheme Types", "Loan Scheme Types", "Loan Scheme Types"));
            ////PayanarSSControls.TreeNode loanMasterNode = AddNode(mesHrmsTreeNode, "Loan Hrms", "Loan Hrms", LoanMasterCollectionViewFactory.Factory, ViewContext.Create("Loan Hrms", "Loan Hrms", "Loan Hrms"));
            ////////PayanarSSControls.TreeNode nominationDetailsNode = AddNode(mastersTreeNode, "Nomination Details", "Nomination Details", NominationDetailsCollectionViewFactory.Factory, ViewContext.Create("Nomination Details", "Nomination Details", "Nomination Details"));
            ////////PayanarSSControls.TreeNode personNode = AddNode(mastersTreeNode, "Persons", "Persons", PersonCollectionViewFactory.Factory, ViewContext.Create("Persons", "Persons", "Persons"));
            ////////PayanarSSControls.TreeNode personCategoryNode = AddNode(mastersTreeNode, "Person Categories", "Person Categories", PersonCategoryCollectionViewFactory.Factory, ViewContext.Create("Person Categories", "Person Categories", "Person Categories"));
            ////PayanarSSControls.TreeNode recoveryTypeNode = AddNode(mesHrmsTreeNode, "Recovery Types", "Recovery Types", RecoveryTypeCollectionViewFactory.Factory, ViewContext.Create("Recovery Types", "Recovery Types", "Recovery Types"));
            ////PayanarSSControls.TreeNode relationsNode = AddNode(mesHrmsTreeNode, "Relations", "Relations", RelationCollectionViewFactory.Factory, ViewContext.Create("Relations", "Relations", "Relations"));
            ////////PayanarSSControls.TreeNode transferTypeNode = AddNode(mesHrmsTreeNode, "Transfer Types", "Transfer Types", TransferTypeCollectionViewFactory.Factory, ViewContext.Create("Transfer Types", "Transfer Types", "Transfer Types"));
            ////////PayanarSSControls.TreeNode witnessDetailsNode = AddNode(mastersTreeNode, "Witness Details", "Witness Details", WitnessDetailsCollectionViewFactory.Factory, ViewContext.Create("Witness Details", "Witness Details", "Witness Details"));

            ////// Payanar.SS Transactions
            ////PayanarSSControls.TreeNode aiswaryaDepositSchemeNode = AddNode(mesTransactionsTreeNode, "Aiswarya Deposit Schemes", "Aiswarya Deposit Schemes", AiswaryaDepositSchemeCollectionViewFactory.Factory, ViewContext.Create("Aiswarya Deposit Schemes", "Aiswarya Deposit Schemes", "Aiswarya Deposit Schemes"));
            ////PayanarSSControls.TreeNode fixedDepositNode = AddNode(mesTransactionsTreeNode, "Fixed Deposits", "Fixed Deposits", FixedDepositCollectionViewFactory.Factory, ViewContext.Create("Fixed Deposits", "Fixed Deposits", "Fixed Deposits"));
            ////////PayanarSSControls.TreeNode fixedDepositNominationDetailsMappingNode = AddNode(fixedDepositNode, "Fixed Deposit Nomination Details Mapping", "Fixed Deposit Nomination Details Mapping", FixedDepositNominationDetailsMappingCollectionViewFactory.Factory, ViewContext.Create("Fixed Deposit Nomination Details Mapping", "Fixed Deposit Nomination Details Mapping", "Fixed Deposit Nomination Details Mapping"));
            ////////PayanarSSControls.TreeNode fixedDepositMonthlyInterestDetailsNode = AddNode(fixedDepositNode, "Fixed Deposit Monthly Interest Details", "Fixed Deposit Monthly Interest Details", FixedDepositMonthlyInterestDetailsCollectionViewFactory.Factory, ViewContext.Create("Fixed Deposit Monthly Interest Details", "Fixed Deposit Monthly Interest Details", "Fixed Deposit Monthly Interest Details"));
            ////////PayanarSSControls.TreeNode monthlyInterrestTransferDetailsNode = AddNode(fixedDepositNode, "Monthly Interrest Transfer Details", "Monthly Interrest Transfer Details", MonthlyInterrestTransferDetailsCollectionViewFactory.Factory, ViewContext.Create("Monthly Interrest Transfer Details", "Monthly Interrest Transfer Details", "Monthly Interrest Transfer Details"));
            ////PayanarSSControls.TreeNode loanApplicationNode = AddNode(mesTransactionsTreeNode, "Loan Applications", "Loan Applications", LoanApplicationCollectionViewFactory.Factory, ViewContext.Create("Loan Applications", "Loan Applications", "Loan Applications"));
            ////////PayanarSSControls.TreeNode loanApplicationSuretiesNode = AddNode(loanApplicationNode, "Loan Application Sureties", "Loan Application Sureties", LoanApplicationSuretiesCollectionViewFactory.Factory, ViewContext.Create("Loan Application Sureties", "Loan Application Sureties", "Loan Application Sureties"));
            ////PayanarSSControls.TreeNode loanPaymentNode = AddNode(mesTransactionsTreeNode, "Loan Payments", "Loan Payments", LoanPaymentCollectionViewFactory.Factory, ViewContext.Create("Loan Payments", "Loan Payments", "Loan Payments"));
            ////////PayanarSSControls.TreeNode loanRefixMonthlyCuttingNode = AddNode(loanPaymentNode, "Loan Refix Monthly Cuttings", "Loan Refix Monthly Cuttings", LoanRefixMonthlyCuttingCollectionViewFactory.Factory, ViewContext.Create("Loan Refix Monthly Cuttings", "Loan Refix Monthly Cuttings", "Loan Refix Monthly Cuttings"));
            ////PayanarSSControls.TreeNode refixLoanMonthlyCuttingNode = AddNode(mesTransactionsTreeNode, "Refix Loan Monthly Cuttings", "Refix Loan Monthly Cuttings", RefixLoanMonthlyCuttingCollectionViewFactory.Factory, ViewContext.Create("Refix Loan Monthly Cuttings", "Refix Loan Monthly Cuttings", "Refix Loan Monthly Cuttings"));
            ////PayanarSSControls.TreeNode savingAccountNode = AddNode(mesTransactionsTreeNode, "Saving Accounts", "Saving Accounts", SavingAccountCollectionViewFactory.Factory, ViewContext.Create("Saving Accounts", "Saving Accounts", "Saving Accounts"));
            ////////PayanarSSControls.TreeNode savingAccountNominationMappingNode = AddNode(savingAccountNode, "Saving Accounts Nomination Mapping", "Saving Accounts Nomination Mapping", SavingAccountNominationMappingCollectionViewFactory.Factory, ViewContext.Create("Saving Accounts Nomination Mapping", "Saving Accounts Nomination Mapping", "Saving Accounts Nomination Mapping"));
            ////////PayanarSSControls.TreeNode savingAccountGuardianMappingNode = AddNode(savingAccountNode, "Saving Accounts Guardian Mapping", "Saving Accounts Guardian Mapping", SavingAccountGuardianMappingCollectionViewFactory.Factory, ViewContext.Create("Saving Accounts Guardian Mapping", "Saving Accounts Guardian Mapping", "Saving Accounts Guardian Mapping"));
            ////////PayanarSSControls.TreeNode savingAccountWitnessDetailsMappingNode = AddNode(savingAccountNode, "Saving Account Witness Details Mapping", "Saving Account Witness Details Mapping", SavingAccountWitnessDetailsMappingCollectionViewFactory.Factory, ViewContext.Create("Saving Account Witness Details Mapping", "Saving Account Witness Details Mapping", "Saving Account Witness Details Mapping"));
            ////////PayanarSSControls.TreeNode savingAccountOperatedByNode = AddNode(savingAccountNode, "Saving Accounts OperatedBy", "Saving Accounts OperatedBy", SavingAccountOperatedByCollectionViewFactory.Factory, ViewContext.Create("Saving Accounts OperatedBy", "Saving Accounts OperatedBy", "Saving Accounts OperatedBy"));

            ////// Chitty Hrms
            ////PayanarSSControls.TreeNode chittyAuctionFixByNode = AddNode(chittyHrmsTreeNode, "Chitties Auction FixBy", "Chitties Auction FixBy", ChittyAuctionFixByCollectionViewFactory.Factory, ViewContext.Create("Chitties Auction FixBy", "Chitties Auction FixBy", "Chitties Auction FixBy"));
            ////PayanarSSControls.TreeNode chittyRecoveryByNode = AddNode(chittyHrmsTreeNode, "Chitties Recovery By", "Chitties Recovery By", ChittyRecoveryByCollectionViewFactory.Factory, ViewContext.Create("Chitties Recovery By", "Chitties Recovery By", "Chitties Recovery By"));

            ////// Chitty Transactions
            ////PayanarSSControls.TreeNode mDSRegisterNode = AddNode(chittyTransactionsTreeNode, "MDS Registeries", "MDS Registeries", MDSRegisterCollectionViewFactory.Factory, ViewContext.Create("MDS Registeries", "MDS Registeries", "MDS Registeries"));
            ////PayanarSSControls.TreeNode chittyRegisterNode = AddNode(chittyTransactionsTreeNode, "Chitty Registeries", "Chitty Registeries", ChittyRegisterCollectionViewFactory.Factory, ViewContext.Create("Chitty Registeries", "Chitty Registeries", "Chitty Registeries"));
            ////PayanarSSControls.TreeNode chittyAuctionHeaderNode = AddNode(chittyTransactionsTreeNode, "Chitties Auction Header", "Chitties Auction Header", ChittyAuctionHeaderCollectionViewFactory.Factory, ViewContext.Create("Chitties Auction Header", "Chitties Auction Header", "Chitties Auction Header"));
            ////////PayanarSSControls.TreeNode chittyAuctionWitnessDetailsNode = AddNode(chittyAuctionHeaderNode, "Chitty Auction Witness Details", "Chitty Auction Witness Details", ChittyAuctionWitnessDetailsCollectionViewFactory.Factory, ViewContext.Create("Chitty Auction Witness Details", "Chitty Auction Witness Details", "Chitty Auction Witness Details"));
            ////PayanarSSControls.TreeNode chittyAuctionPaymentsNode = AddNode(chittyTransactionsTreeNode, "Chitty Auction Payments", "Chitty Auction Payments", ChittyAuctionPaymentCollectionViewFactory.Factory, ViewContext.Create("Chitty Auction Payments", "Chitty Auction Payments", "Chitty Auction Payments"));
            ////////PayanarSSControls.TreeNode chittyNominationDetailsMappingNode = AddNode(chittyRegisterNode, "Chitty Nomination Details Mapping", "Chitty Nomination Details Mapping", ChittyNominationDetailsMappingCollectionViewFactory.Factory, ViewContext.Create("Chitty Nomination Details Mapping", "Chitty Nomination Details Mapping", "Chitty Nomination Details Mapping"));
            ////////PayanarSSControls.TreeNode chittyRegisterMemberDetailsNode = AddNode(chittyRegisterNode, "Chitty Register Member Details", "Chitty Register Member Details", ChittyRegisterMemberDetailsCollectionViewFactory.Factory, ViewContext.Create("Chitty Register Member Details", "Chitty Register Member Details", "Chitty Register Member Details"));

            ////////rootTreeNode.ExpandAll();
            ////bankRootTreeNode.ExpandAll();
            ////commonRootTreeNode.ExpandAll();
            ////mesRootTreeNode.ExpandAll();
            ////chittyRootTreeNode.ExpandAll();
        }

        private void OpenDefaultViews(PayanarSSControls.TreeNode treeNode)
        {
            treeNode.CreateView();
            NotifyObserver(treeNode.ViewDetails, "OpenView");
        }
    }
}