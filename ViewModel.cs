namespace ApiTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class ViewModel : DbContext
    {
        public ViewModel()
            : base("name=ViewModel") { }
        //https://msdn.microsoft.com/en-us/library/jj591583(v=vs.113).aspx
        public virtual DbSet<CommonData> CommonData { get; set; }

        public virtual DbSet<ExistingMethod> ExistingMethod { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

    public class CommonData
    {
        [Key]
        public string MethodName { get; set; }
        public string Method { get; set; }
        [Required]
        public string Endpoint { get; set; }
        public Uri Uri { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }

    public class ExistingMethod
    {
        [Key]
        public string MethodName { get; set; }
        [Required]
        public string Resource { get; set; }
        [Required]
        public string Method { get; set; }

        public ExistingMethod(string methN, string res, string meth)
        {
            this.MethodName = methN;
            this.Resource = res;
            this.Method = meth;
        }
    }

    public class ContextData
    {
        ViewModel dbContext = new ViewModel();

        public List<CommonData> GetAllData()
        {
            return dbContext.CommonData.OrderByDescending(t => t.MethodName).ToList();
        }

        public bool AddData(CommonData input, string userName)
        {
            try
            {
                //input.CreatedBy = userName;
                //input.CreatedOn = System.DateTime.Now;

                dbContext.CommonData.Add(input);
                dbContext.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        // CALL THIS
        public bool LoadExistingMethods()
        {
            var loadMethods = new List<ExistingMethod>(new[] {
                new ExistingMethod("GetCategories", "/Categories/{classification}?PropertyNumber={propertyNumber}", "GET"),
                new ExistingMethod("GetProperties", "/Properties", "GET"),
                new ExistingMethod("GetPropertyNumberById", "/Property/{propertyIdentifier}", "GET"),
                new ExistingMethod("GetAllProducts", "/Product/{classification}?PropertyNumber={propertyNumber}", "GET"),
                new ExistingMethod("GetPropertyProducts", "/Product/{classification}/PropertyNumber/{propertyNumber}", "GET"),
                new ExistingMethod("GetProductByNumber", "/Product/ProductNumber/{productNumber}?PropertyNumber={propertyNumber}", "GET"),
                new ExistingMethod("GetProductById", "/Product?ProductIdentifier={productIdentifier}&PropertyNumber={propertyNumber}", "GET"),
                new ExistingMethod("GetProductByNumberAndDetail", "/Product/ProductNumber/{productNumber}/DetailNumber/{detailNumber}?PropertyNumber={propertyNumber}", "GET"),
                new ExistingMethod("GetProduct", "/Product/ProductNumber/{productNumber}/DetailNumber/{detailNumber}/PropertyNumber/{propertyNumber}", "GET"),
                new ExistingMethod("CreateProduct", "/Product", "POST"),
                new ExistingMethod("UpdatePropertyProduct", "/Product/ProductNumber/{productNumber}/PropertyNumber/{propertyNumber}", "PUT"),
                new ExistingMethod("UpdateRootProduct", "/Product/ProductNumber/{productNumber}", "PUT"),
                new ExistingMethod("MergeProductDetails", "/Product/ProductNumber/{productNumber}/DetailNumber/{detailNumber}", "DELETE"),
                new ExistingMethod("MergeProducts", "/Product/ProductNumber/{productNumber}", "DELETE"),
                new ExistingMethod("ResetDataBase", "/Product/PropertyNumber/{propertyNumber}", "DELETE"),
                new ExistingMethod("UpdateCoreList", "/CoreListProduct?PropertyNumber={propertyNumber}", "PUT"),
                new ExistingMethod("GetCoreList", "/CoreListProduct?PropertyNumber={propertyNumber}", "GET") });
            try
            {
                dbContext.ExistingMethod.AddRange(loadMethods);
                dbContext.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}