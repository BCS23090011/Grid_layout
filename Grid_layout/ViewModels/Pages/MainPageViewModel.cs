using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input; // 需要这个
using System.Diagnostics; // 用于命令示例

namespace Grid_layout.ViewModels
{
    // 继承自您提供的 BaseViewModel
    public class MainPageViewModel : BaseViewModel
    {
        // 宠物信息属性
        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public string PetAge { get; set; }
        public string PetLocation { get; set; }

        // 宠物主人信息属性
        public string OwnerName { get; set; }
        public string OwnerRole { get; set; }
        public string PostDate { get; set; }
        public string Description { get; set; }

        // 命令属性
        public ICommand FavouriteCommand { get; }
        public ICommand AdoptCommand { get; }

        public MainPageViewModel()
        {
            // 初始化数据
            // (这些数据来自您之前的 MainPage.xaml)
            PetName = "Robin Hood"; // [cite: 5]
            PetBreed = "Pug"; // [cite: 5]
            PetAge = "1 years old"; // [cite: 6]
            PetLocation = "2B, Lorong Deshon Timur 17A4"; // [cite: 7, 8]

            OwnerName = "Jeon Jungkook"; // [cite: 13]
            OwnerRole = "Owner"; // [cite: 14, 15]
            PostDate = "1/1/2024"; // [cite: 16]
            Description = "Hi!\nRobin the Pug is simply a tiny tornado of fun, wrinkles, and endless charm."; // [cite: 17, 18]

            // 初始化命令
            FavouriteCommand = new Command(OnFavourite);
            AdoptCommand = new Command(OnAdopt);
        }

        private void OnFavourite()
        {
            // 这里放“喜欢”按钮的逻辑
            Debug.WriteLine("Favourite button clicked!");
        }

        private void OnAdopt()
        {
            // 这里放“领养”按钮的逻辑
            Debug.WriteLine("Adoption button clicked!");
        }
    }
}