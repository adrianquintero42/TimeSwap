using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeSwap.Model
{
    public class Service
    {
        private int id;
        private string title;
        private string descriptionService;
        private int durationService;
        private int type;
        private int rIdUser;
        private int rIdCategoryService;
        private string user;
        private string userImg;
        private string userPhone;

        public Service() {}

        public Service(int id, string title, string descriptionService, int durationService, int type, int rIdUser, int rIdCategoryService, string user, string userImg, string userPhone)
        {
            Id = id;
            Title = title;
            DescriptionService = descriptionService;
            DurationService = durationService;
            TypeService = type;
            RIdUser = rIdUser;
            RIdCategoryService = rIdCategoryService;
            ServiceUser = user;
            UserImg = userImg;
            UserPhone = userPhone;
        }

        public int Id { get => id; set => id = value; }

        public string Title { get => title; set => title = value; }

        public string DescriptionService { get => descriptionService; set => descriptionService = value; }

        public int DurationService { get => durationService; set => durationService = value; }

        public int TypeService { get => type; set => type = value; }

        public int RIdUser { get => rIdUser; set => rIdUser = value; }

        public int RIdCategoryService { get => rIdCategoryService; set => rIdCategoryService = value; }
        public string ServiceUser { get => user; set => user = value; }
        public string UserImg { get => userImg; set => userImg = value; }
        public string UserPhone { get => userPhone; set => userPhone = value; }

    }
}