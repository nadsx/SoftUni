namespace CollectionHierarchy.Models
{
    using Contracts;

    public class MyList : AddRemoveCollection, IMyList
    {
        public override string Remove()
        {
            string firstItem = this.DataCollection[0];
            this.DataCollection.RemoveAt(0);

            return firstItem;
        }

        public string Used()
        {
            return string.Join(" ", this.DataCollection);
        }
    }
}