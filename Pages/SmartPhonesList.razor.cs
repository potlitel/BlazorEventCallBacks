using BlazorEventCallBacks.Models;

namespace BlazorEventCallBacks.Pages
{
    public partial class SmartPhonesList
    {
        private List<SmartPhoneEntity> SmartPhones = new();
        private int FavouritePhoneCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SmartPhones.Add(new()
            {
                Id = 1,
                SmartPhoneName = "iPhone 12",
                IsAvailable = false,
                Price = "$ 850",
                SmartPhoneFeatures = new()
                {
                    new Feature { Specification = "Chip", Value = "A14 Bionic chip" },
                    new Feature { Specification = "Display", Value = "Super Retina XDR display" },
                    new Feature { Specification = "Camera", Value = "Wide and Ultra Wide" }
                }
            });
            SmartPhones.Add(new()
            {
                Id = 2,
                SmartPhoneName = "iPhone 13",
                IsAvailable = false,
                Price = "$ 1050",
                SmartPhoneFeatures = new()
                {
                    new Feature { Specification = "Chip", Value = "A15 Bionic chip" },
                    new Feature { Specification = "Display", Value = "Super Retina XDR display" },
                    new Feature { Specification = "Camera", Value = "Telephoto, Wide and Ultra Wide" }
                }
            });
        }

        protected void FavouriteCountUpdate(bool isSelected)
        {
            if (isSelected)
            {
                FavouritePhoneCount++;
            }
            else
            {
                FavouritePhoneCount--;
            }
        }
    }
}