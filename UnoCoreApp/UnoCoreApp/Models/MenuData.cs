using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UnoCoreApp.Models
{
    public class MenuData
    {
        static List<MenuOption> allMenuOptions;
        public static List<MenuOption> AllMenuOptions
        {
            get
            {
                if (allMenuOptions == null)
                {
                    allMenuOptions = new List<MenuOption>
                    {
                        new MenuOption
                        {
                            Id = 1,
                            GroupId = 1,
                            Nivel = 0,
                            GroupName = "Principal Menu",
                            Name="My Carrer",
                            Description="Information about you and your carrier path",
                            ImageName = "mycarrer.png",
                            GoForm = "",
                            ParentId = 0
                        },
                        new MenuOption
                        {
                            Id = 2,
                            GroupId = 1,
                            Nivel = 0,
                            GroupName = "Principal Menu",
                            Name="ParkingLot",
                            Description="Information about your parking or way to work",
                            ImageName = "parkingLot.png",
                            GoForm = "",
                            ParentId = 0
                        },
                        new MenuOption
                        {
                            Id = 3,
                            GroupId = 1,
                            Nivel = 0,
                            GroupName = "Principal Menu",
                            Name="Benefits",
                            Description="Your benefits in UnoSquare",
                            ImageName = "benefits.png",
                            GoForm = "",
                            ParentId = 0
                        },
                        new MenuOption
                        {
                            Id = 4,
                            GroupId = 1,
                            Nivel = 0,
                            GroupName = "Principal Menu",
                            Name="Lunch Core",
                            Description="All about your lunch (request, receipt, cancel)",
                            ImageName = "lunchCore.jpg",
                            GoForm = "",
                            ParentId = 0
                        },
                        new MenuOption
                        {
                            Id = 5,
                            GroupId = 1,
                            Nivel = 0,
                            GroupName = "Principal Menu",
                            Name="My Events",
                            Description="What events you going to attend?",
                            ImageName = "events.png",
                            GoForm = "",
                            ParentId = 0
                        },
                        new MenuOption
                        {
                            Id = 6,
                            GroupId = 2,
                            Nivel = 1,
                            GroupName = "Carrer",
                            Name="Profile",
                            Description="All about you",
                            ImageName = "profile.png",
                            GoForm = "",
                            ParentId = 1
                        },
                        new MenuOption
                        {
                            Id = 7,
                            GroupId = 2,
                            Nivel = 1,
                            GroupName = "Carrer",
                            Name="Annual Review",
                            Description="Track your annual review",
                            ImageName = "annualReview.png",
                            GoForm = "",
                            ParentId = 1
                        },
                        new MenuOption
                        {
                            Id = 8,
                            GroupId = 2,
                            Nivel = 1,
                            GroupName = "Carrer",
                            Name="Uno mailbox",
                            Description="What you want to tell us?",
                            ImageName = "mailbox.png",
                            GoForm = "",
                            ParentId = 1
                        },
                        new MenuOption
                        {
                            Id = 9,
                            GroupId = 3,
                            Nivel = 1,
                            GroupName = "Parking",
                            Name="Request",
                            Description="Request a lot",
                            ImageName = "requestParking.jpg",
                            GoForm = "",
                            ParentId = 2
                        },
                        new MenuOption
                        {
                            Id = 10,
                            GroupId = 3,
                            Nivel = 1,
                            GroupName = "Parking",
                            Name="Ride",
                            Description="Do you need a ride?",
                            ImageName = "ride.png",
                            GoForm = "",
                            ParentId = 2
                        },
                        new MenuOption
                        {
                            Id = 11,
                            GroupId = 3,
                            Nivel = 1,
                            GroupName = "Parking",
                            Name="Temporaly free",
                            Description="Free your lot to a partner",
                            ImageName = "temporalyFree.png",
                            GoForm = "",
                            ParentId = 2
                        },
                        new MenuOption
                        {
                            Id = 12,
                            GroupId = 3,
                            Nivel = 1,
                            GroupName = "Parking",
                            Name="Subsidy",
                            Description="Uno give you a hand",
                            ImageName = "subsidy.png",
                            GoForm = "",
                            ParentId = 2
                        },
                        new MenuOption
                        {
                            Id = 13,
                            GroupId = 4,
                            Nivel = 1,
                            GroupName = "Benefits",
                            Name="Saving",
                            Description="Request an annual saving",
                            ImageName = "savings.jpg",
                            GoForm = "",
                            ParentId = 3
                        },
                        new MenuOption
                        {
                            Id = 14,
                            GroupId = 4,
                            Nivel = 1,
                            GroupName = "Benefits",
                            Name="Healty",
                            Description="Healt places to you",
                            ImageName = "healty.png",
                            GoForm = "",
                            ParentId = 3
                        },
                        new MenuOption
                        {
                            Id = 15,
                            GroupId = 4,
                            Nivel = 1,
                            GroupName = "Benefits",
                            Name="Discounts",
                            Description="Save money with our partners",
                            ImageName = "discount.png",
                            GoForm = "",
                            ParentId = 3
                        },
                        new MenuOption
                        {
                            Id = 16,
                            GroupId = 5,
                            Nivel = 1,
                            GroupName = "LunchCore",
                            Name="Order",
                            Description="Order your lunch",
                            ImageName = "orderFood.png",
                            GoForm = "",
                            ParentId = 4
                        },
                        new MenuOption
                        {
                            Id = 17,
                            GroupId = 5,
                            Nivel = 1,
                            GroupName = "LunchCore",
                            Name="Cancel your order",
                            Description="Cancel your lunch",
                            ImageName = "cancelOrderFood.png",
                            GoForm = "",
                            ParentId = 4
                        },
                        new MenuOption
                        {
                            Id = 18,
                            GroupId = 5,
                            Nivel = 1,
                            GroupName = "LunchCore",
                            Name="Receipt",
                            Description="Check your receipt",
                            ImageName = "receipt.png",
                            GoForm = "",
                            ParentId = 4
                        },
                        new MenuOption
                        {
                            Id = 19,
                            GroupId = 5,
                            Nivel = 1,
                            GroupName = "LunchCore",
                            Name="Review",
                            Description="Give us your opinion",
                            ImageName = "review.png",
                            GoForm = "",
                            ParentId = 4
                        },
                        new MenuOption
                        {
                            Id = 20,
                            GroupId = 6,
                            Nivel = 1,
                            GroupName = "Events",
                            Name="RSVP",
                            Description="Reserv your place",
                            ImageName = "rsvp.jpg",
                            GoForm = "",
                            ParentId = 5
                        },
                        new MenuOption
                        {
                            Id = 21,
                            GroupId = 6,
                            Nivel = 1,
                            GroupName = "Events",
                            Name="Pictures",
                            Description="Share & View your moments",
                            ImageName = "pictures.png",
                            GoForm = "",
                            ParentId = 5
                        }
                    };
                }
                return allMenuOptions;
            }
            set
            {
                allMenuOptions = value;
            }
        }

        public static ListMenuView GetMenuOptionByParent(int parentId)
        {
            ListMenuView menu = new ListMenuView("Principal", "Principal menu");

            var parent = MenuData.AllMenuOptions.Find(o => o.Id == parentId);

            if (parent != null)
                menu = new ListMenuView(parent.GroupName, parent.Description);

            menu.Options = MenuData.AllMenuOptions.Where(o => o.ParentId == parentId).ToList();

            return menu;
        }
    }
}
