namespace shoppingAPP_mvc.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public int pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pCategory="Cold-Drink", pName="Pepsi", pIsInStock=true, pPrice=50 },
            new Products(){ pId=102, pCategory="Electronics", pName="IPhone", pIsInStock=true, pPrice=50 },
            new Products(){ pId=103, pCategory="Electronics", pName="Air-Pods", pIsInStock=false, pPrice=50 },
            new Products(){ pId=104, pCategory="Shoe", pName="Nike", pIsInStock=true, pPrice=50 },
            new Products(){ pId=105, pCategory="Fast-Food", pName="Maggie", pIsInStock=true, pPrice=50 },
            new Products(){ pId=106, pCategory="Fast-Food", pName="Sandwitch", pIsInStock=false, pPrice=50 },
            new Products(){ pId=107, pCategory="Coffee", pName="Latte", pIsInStock=true, pPrice=50 },
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }
    }
}
