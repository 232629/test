namespace UITestDirect2.Core.Helpers
{
    /// <summary>
    /// Structs for function of registration. Step 0. 
    /// </summary>
    public struct DataStep0
    {
        private string txtEmail;
        private string txtPassword;
        private string txtFirstName;
        private string txtLastName;
        private string cmbCountry;
        private string cmbRegulator;
        private bool btnNexStep;

        public string TxtEmail { get => txtEmail; set => txtEmail = value; }
        public string TxtPassword { get => txtPassword; set => txtPassword = value; }
        public string TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public string TxtLastName { get => txtLastName; set => txtLastName = value; }
        public string CmbCountry { get => cmbCountry; set => cmbCountry = value; }  
        public string CmbRegulator { get => cmbRegulator; set => cmbRegulator = value; }
        public bool BtnNexStep { get => btnNexStep; set => btnNexStep = value; }

    }
    
    
    /// <summary>
    /// Structs for function of registration. Step 1. 
    /// </summary>
    public struct DataStep1
    {
        private string txtAddress;
        private string txtPostcode;
        private string txtCity;
        private string cmbEmirate;  
        private string txtBirthdate;
        private string txtPhone;
        private string txtQq;
        private string cmbNationality;
        private bool btnNexStep;
        
        public string TxtAddress { get => txtAddress; set => txtAddress = value; }
        public string TxtPostcode { get => txtPostcode; set => txtPostcode = value; }
        public string TxtCity { get => txtCity; set => txtCity = value; }
        public string CmbEmirate { get => cmbEmirate; set => cmbEmirate = value; }
        public string TxtBirthdate { get => txtBirthdate; set => txtBirthdate = value; }
        public string TxtPhone { get => txtPhone; set => txtPhone = value; }
        public string TxtQq { get => txtQq; set => txtQq = value; }
        public string CmbNationality { get => cmbNationality; set => cmbNationality = value; }
        public bool BtnNexStep { get => btnNexStep; set => btnNexStep = value; }
    }

    /// <summary>
    /// Structs for function of registration. Step 2. 
    /// </summary>
    public struct DataStep2
    {
        private string cmbEmployment;
        private string cmbEmploymentType;
            private string txtEmploymentOther;
        private string cmbLevelOfEducation;

        private string cmbAnnualIncome;
        private string cmbEstimatedNetWorth;
        private string cmbSourceOfIncome;
            private string txtSourceOfIncomeOther;
        private string cmbDeposit;
        private bool chkToTradeCFDs;
            private bool chkToTradeCFDsOnForex;
            private bool chkToTradeCFDsOnShares;
            private bool chkToTradeCFDsOnIndices;
        private DataUsCitizen dataUsCitizen;

        //Do you have any trading experience?
        private string cmbTradingExperience;
            //Yes, I have traded on a real account
            private string cmbExperience;
            private string cmbHowManyTimesYouTraded;
            //No
            private bool chkIHaveRelevantEducational;
            private bool chkIRegularlyMonitorNews;
            private bool chkIHaveReadMaterialOnTrading;
            private bool chkAllOfAbove;
            private bool chkNoneOfAbove;

        private string cmbQuestion1;
        private string cmbQuestion2;
        private string cmbQuestion3;

        private bool chkProfessionalClientYes;
        private bool chkProfessionalClientNO;
        private string cmbLeveragedProductExperience;
        private string txtLeveragedProductExperienceOther;

        private bool btnNexStep; 

        public string CmbEmployment { get => cmbEmployment; set => cmbEmployment = value; }
        public string CmbEmploymentType { get => cmbEmploymentType; set => cmbEmploymentType = value; }
            public string TxtEmploymentOther { get => txtEmploymentOther; set => txtEmploymentOther = value; }
        public string CmbLevelOfEducation { get => cmbLevelOfEducation; set => cmbLevelOfEducation = value; }
        public string CmbAnnualIncome { get => cmbAnnualIncome; set => cmbAnnualIncome = value; }
        public string CmbEstimatedNetWorth { get => cmbEstimatedNetWorth; set => cmbEstimatedNetWorth = value; }
        public string CmbSourceOfIncome { get => cmbSourceOfIncome; set => cmbSourceOfIncome = value; }
            public string TxtSourceOfIncomeOther { get => txtSourceOfIncomeOther; set => txtSourceOfIncomeOther = value; }
        public string CmbDeposit { get => cmbDeposit; set => cmbDeposit = value; }
        public bool ChkToTradeCFDs { get => chkToTradeCFDs; set => chkToTradeCFDs = value; }
            public bool ChkToTradeCFDsOnForex { get => chkToTradeCFDsOnForex; set => chkToTradeCFDsOnForex = value; }
            public bool ChkToTradeCFDsOnShares { get => chkToTradeCFDsOnShares; set => chkToTradeCFDsOnShares = value; }
            public bool ChkToTradeCFDsOnIndices { get => chkToTradeCFDsOnIndices; set => chkToTradeCFDsOnIndices = value; }
        public DataUsCitizen UsCitizen { get => dataUsCitizen; set => dataUsCitizen = value; }
            
        //Do you have any trading experience?
        public string CmbTradingExperience { get => cmbTradingExperience; set => cmbTradingExperience = value; }
            //Yes, I have traded on a real account
            public string CmbExperience { get => cmbExperience; set => cmbExperience = value; }
            public string CmbHowManyTimesYouTraded { get => cmbHowManyTimesYouTraded; set => cmbHowManyTimesYouTraded = value; }
            //No
            public bool ChkHaveRelevantEducational { get => chkIHaveRelevantEducational; set => chkIHaveRelevantEducational = value; }  
            public bool ChkIRegularlyMonitorNews { get => chkIRegularlyMonitorNews; set => chkIRegularlyMonitorNews = value; }
            public bool ChkIHaveReadMaterialOnTrading { get => chkIHaveReadMaterialOnTrading; set => chkIHaveReadMaterialOnTrading = value; }
            public bool ChkAllOfAbove { get => chkAllOfAbove; set => chkAllOfAbove = value; }
            public bool ChkNoneOfAbove { get => chkNoneOfAbove; set => chkNoneOfAbove = value; }

        public string CmbQuestion1 { get => cmbQuestion1; set => cmbQuestion1 = value; }
        public string CmbQuestion2 { get => cmbQuestion2; set => cmbQuestion2 = value; }
        public string CmbQuestion3 { get => cmbQuestion3; set => cmbQuestion3 = value; }
        
        public bool ChkProfessionalClientYes { get => chkProfessionalClientYes; set => chkProfessionalClientYes = value; }
        public bool ChkProfessionalClientNo { get => chkProfessionalClientNO; set => chkProfessionalClientNO = value; }
        public string CmbLeveragedProductExperience { get => cmbLeveragedProductExperience; set => cmbLeveragedProductExperience = value; }
        public string TxtLeveragedProductExperienceOther { get => txtLeveragedProductExperienceOther; set => txtLeveragedProductExperienceOther = value; }

        public bool BtnNexStep { get => btnNexStep; set => btnNexStep = value; }

        /// <summary>
        /// Trading Experience
        /// if btnTradingExperience = true, Trading Experience = Yes. (push PageRregisterStep2.btnTradingExperienceYes)
        /// if btnTradingExperience = false, Trading Experience = NO. (push PageRregisterStep2.btnTradingExperienceNo)
        /// </summary>
        //public class DataTradingExperience
        //{
        //    private bool btnTradingExperience;
        //    private string cmbExperience;
        //    private string cmbHowManyTimesYouTraded;

        //    private bool chkIHaveRelevantEducational;
        //    private bool chkIRegularlyMonitorNews;
        //    private bool chkIHaveReadMaterialOnTrading;
        //    private bool chkAllOfAbove;
        //    private bool chkNoneOfAbove;

        //    public DataTradingExperience(bool btnTradingExperience)
        //    {
        //        BtnTradingExperience = btnTradingExperience;
        //    }


        //    public bool BtnTradingExperience { get; }
        //    public string CmbExperience
        //    {
        //        get => cmbExperience;
        //        set => cmbExperience = BtnTradingExperience ? value : null;
        //    }
        //    public string CmbHowManyTimesYouTraded
        //    {
        //        get => cmbHowManyTimesYouTraded;
        //        set => cmbHowManyTimesYouTraded = BtnTradingExperience ? value : null;
        //    }

        //    public bool ChkHaveRelevantEducational
        //    {
        //        get => chkIHaveRelevantEducational;
        //        set => chkIHaveRelevantEducational = BtnTradingExperience ? false : value;
        //    }

        //    public bool ChkIRegularlyMonitorNews
        //    {
        //        get => chkIRegularlyMonitorNews;
        //        set => chkIRegularlyMonitorNews = BtnTradingExperience ? false : value;
        //    }

        //    public bool ChkIHaveReadMaterialOnTrading
        //    {
        //        get => chkIHaveReadMaterialOnTrading;
        //        set => chkIHaveReadMaterialOnTrading = BtnTradingExperience ? false : value;
        //    }

        //    public bool ChkAllOfAbove
        //    {
        //        get => chkAllOfAbove;
        //        set => chkAllOfAbove = BtnTradingExperience ? false : value;
        //    }

        //    public bool ChkNoneOfAbove
        //    {
        //        get => chkNoneOfAbove;
        //        set => chkNoneOfAbove = BtnTradingExperience ? false : value;
        //    }
        //}

        /// <summary>
        ///Are you a US citizen or a US resident for tax purposes?
        /// </summary>
        public class DataUsCitizen
        {
            private bool btnUScitizen;
            private string txtUsTaxCode;

            public DataUsCitizen(bool btnUScitizen)
            {
                BtnUScitizen = btnUScitizen;
            }

            public bool BtnUScitizen { get; }
            public string TxtUsTaxCode
            {
                get => txtUsTaxCode;
                set => txtUsTaxCode = BtnUScitizen ? value : null;
            }
 
        }
    }

    /// <summary>
    /// Structs for function of registration. Step 3. 
    /// </summary>
    public struct DataStep3
    {
        private string cmbAccountType;
        private string cmbLeverage;
        private string cmbCurrencyBase;
        private bool btnVerifyYourProfileYes;
        private bool btnVerifyYourProfileNo;
        private bool chkReceiveCompanyNews;
        private bool chkReceiveTechnicalAnalysis;
        private string cmbLanguage;
        private bool chkAcceptRisks;
        private bool chkClientAgreement;
        private bool btnComplete;

        public string CmbAccountType { get => cmbAccountType; set => cmbAccountType = value; }
        public string CmbLeverage { get => cmbLeverage; set => cmbLeverage = value; }
        public string CmbCurrencyBase { get => cmbCurrencyBase; set => cmbCurrencyBase = value; }
        public bool BtnVerifyYourProfileYes { get => btnVerifyYourProfileYes; set => btnVerifyYourProfileYes = value; }
        public bool BtnVerifyYourProfileNo { get => btnVerifyYourProfileNo; set => btnVerifyYourProfileNo = value; }
        public bool ChkReceiveCompanyNews { get => chkReceiveCompanyNews; set => chkReceiveCompanyNews = value; }
        public bool ChkReceiveTechnicalAnalysis { get => chkReceiveTechnicalAnalysis; set => chkReceiveTechnicalAnalysis = value; }
        public string CmbLanguage { get => cmbLanguage; set => cmbLanguage = value; }
        public bool ChkAcceptRisks { get => chkAcceptRisks; set => chkAcceptRisks = value; }
        public bool ChkClientAgreement { get => chkClientAgreement; set => chkClientAgreement = value; }
        public bool BtnComplete { get => btnComplete; set => btnComplete = value; }
    }


}
       

