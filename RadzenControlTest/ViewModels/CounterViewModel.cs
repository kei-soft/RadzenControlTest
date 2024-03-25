namespace RadzenControlTest.ViewModels
{
    public class CounterViewModel
    {
        public int Count { get; set; }

        public CounterViewModel()
        {

        }

        public void IncrementCount()
        {
            Count += 1;
        }
    }
}
