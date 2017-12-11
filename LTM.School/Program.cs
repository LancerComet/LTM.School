using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LTM.School.EntityFramework;
using LTM.School.EntityFramework.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LTM.School {
    public class Program {
        public static void Main(string[] args) {
            var host = BuildWebHost(args);

            // 应该是创建了一个作用域对象, 然后这个对象可以使用依赖注入的方式获取任意服务.
            using (var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;
                try {
                    // 初始化数据库.
                    var context = services.GetRequiredService<SchoolDbContext>();
                    DbInitializer.Initialize(context);
                } catch (Exception error) {
                    // 注入日志服务.
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(error, "初始化系统测试数据错误.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
