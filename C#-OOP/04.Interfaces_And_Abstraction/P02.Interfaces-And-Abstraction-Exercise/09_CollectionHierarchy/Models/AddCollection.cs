namespace CollectionHierarchy.Models
{
    public class AddCollection : Collection
    {
        public override int Add(string item)
        {
            this.DataCollection.Add(item);

            return DataCollection.Count - 1;
        }
    }
}