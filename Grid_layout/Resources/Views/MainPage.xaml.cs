// 1. 添加 using
using Grid_layout.ViewModels;

namespace Grid_layout
{
    public partial class MainPage : ContentPage
    {
        // 2. 移除 count 变量

        // 3. 修改构造函数以接收 ViewModel
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            // 4. 设置 BindingContext
            BindingContext = viewModel;
        }
    }
}