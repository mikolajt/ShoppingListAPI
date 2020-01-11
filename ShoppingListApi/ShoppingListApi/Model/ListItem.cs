namespace ShoppingListApi.Model
{
    public class ListItem
    {
        public long ListItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool IsComplete { get; set; }
    }
}
