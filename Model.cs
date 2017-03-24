namespace ApiTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Model : DbContext
    {
        public Model()
            : base("name=Model") { }
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
        public string methodName { get; set; }
        public string method { get; set; }
        [Required]
        public string endpoint { get; set; }
        public Uri uri { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }

    public class ExistingMethod
    {
        [Key]
        public string methodName { get; set; }
        [Required]
        public string resource { get; set; }
        [Required]
        public string method { get; set; }

        public ExistingMethod(string methN, string res, string meth)
        {
            this.methodName = methN;
            this.resource = res;
            this.method = meth;
        }
    }

    public class ContextData
    {
        Model dbContext = new Model();

        public List<CommonData> GetAllData()
        {
            return dbContext.CommonData.OrderByDescending(t => t.methodName).ToList();
        }

        public bool AddData(CommonData input, string UserName)
        {
            try
            {
                //input.CreatedBy = UserName;
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