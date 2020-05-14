using System;
using System.Collections.Generic;
using System.Linq;
using ActivityService.Domain;

namespace ActivityService.Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "出趟远门",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "都两个月过去了，还宅家",
                        Category = "travel",
                        City = "西安",
                        Venue = "边城",
                    },
                    new Activity
                    {
                        Title = "读点书",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "想把一面墙的书都读完，可是书都垫桌子腿儿了",
                        Category = "culture",
                        City = "上海",
                        Venue = "家",
                    },
                    new Activity
                    {
                        Title = "白天不起床",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "就睡个一整天",
                        Category = "home",
                        City = "上海",
                        Venue = "家",
                    },
                    new Activity
                    {
                        Title = "跑一圈",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "护城河，古城墙，夕阳下",
                        Category = "sport",
                        City = "襄阳",
                        Venue = "护城河边",
                    },
                    new Activity
                    {
                        Title = "其他的事情 3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "unknow",
                        City = "未知",
                        Venue = "未知",
                    },
                    new Activity
                    {
                        Title = "其他的事情 4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "unknow",
                        City = "未知",
                        Venue = "未知",
                    },
                    new Activity
                    {
                        Title = "其他的事情 5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "unknow",
                        City = "未知",
                        Venue = "未知",
                    },
                    new Activity
                    {
                        Title = "其他的事情 6",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "music",
                        City = "未知",
                        Venue = "未知",
                    },
                    new Activity
                    {
                        Title = "其他的事情 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "travel",
                        City = "未知",
                        Venue = "未知",
                    },
                    new Activity
                    {
                        Title = "其他的事情 8",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "没有什么事情了，慢慢想象",
                        Category = "film",
                        City = "未知",
                        Venue = "未知",
                    }
                };


                context.Activities.AddRange(activities);
                context.SaveChanges();
            }

        }
    }
}