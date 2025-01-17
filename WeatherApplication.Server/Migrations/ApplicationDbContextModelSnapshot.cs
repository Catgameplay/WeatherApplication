﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApplication.Server.Data;

#nullable disable

namespace WeatherApplication.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WeatherApplication.Server.Models.CurrentWeather", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double>("CloudsAll")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Humidity")
                        .HasColumnType("double");

                    b.Property<double>("Pressure")
                        .HasColumnType("double");

                    b.Property<double>("Temp")
                        .HasColumnType("double");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("CurrentWeatherCalls");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.FiveDaysWeather", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lon")
                        .HasColumnType("double");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<int>("Sunrise")
                        .HasColumnType("int");

                    b.Property<int>("Sunset")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Timezone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("FiveDaysWeatherCalls");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("CloudsAll")
                        .HasColumnType("int");

                    b.Property<string>("DateText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Dt")
                        .HasColumnType("int");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("double");

                    b.Property<Guid?>("FiveDaysWeatherId")
                        .HasColumnType("char(36)");

                    b.Property<int>("GroundLevel")
                        .HasColumnType("int");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<double>("MinMaxTempDiff")
                        .HasColumnType("double");

                    b.Property<double>("Pop")
                        .HasColumnType("double");

                    b.Property<int>("Pressure")
                        .HasColumnType("int");

                    b.Property<string>("Rain")
                        .HasColumnType("longtext");

                    b.Property<int>("SeaLevel")
                        .HasColumnType("int");

                    b.Property<string>("Snow")
                        .HasColumnType("longtext");

                    b.Property<double>("Temp")
                        .HasColumnType("double");

                    b.Property<double>("TempMax")
                        .HasColumnType("double");

                    b.Property<double>("TempMin")
                        .HasColumnType("double");

                    b.Property<int>("Visibility")
                        .HasColumnType("int");

                    b.Property<string>("WeatherDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WeatherIcon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WeatherMain")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WindDeg")
                        .HasColumnType("int");

                    b.Property<double>("WindGust")
                        .HasColumnType("double");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CurrentWeatherId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("FiveDaysWeatherId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lon")
                        .HasColumnType("double");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CurrentWeatherId");

                    b.HasIndex("FiveDaysWeatherId");

                    b.HasIndex("TenantId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.CurrentWeather", b =>
                {
                    b.HasOne("WeatherApplication.Server.Models.Tenant", "Tenant")
                        .WithMany("CurrentWeatherCalls")
                        .HasForeignKey("TenantId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.FiveDaysWeather", b =>
                {
                    b.HasOne("WeatherApplication.Server.Models.Tenant", "Tenant")
                        .WithMany("FiveDaysWeatherCalls")
                        .HasForeignKey("TenantId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Item", b =>
                {
                    b.HasOne("WeatherApplication.Server.Models.FiveDaysWeather", "FiveDaysWeather")
                        .WithMany("Items")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FiveDaysWeather");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Record", b =>
                {
                    b.HasOne("WeatherApplication.Server.Models.CurrentWeather", "CurrentWeather")
                        .WithMany()
                        .HasForeignKey("CurrentWeatherId");

                    b.HasOne("WeatherApplication.Server.Models.FiveDaysWeather", "FiveDaysWeather")
                        .WithMany()
                        .HasForeignKey("FiveDaysWeatherId");

                    b.HasOne("WeatherApplication.Server.Models.Tenant", "Tenant")
                        .WithMany("Records")
                        .HasForeignKey("TenantId");

                    b.Navigation("CurrentWeather");

                    b.Navigation("FiveDaysWeather");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.User", b =>
                {
                    b.HasOne("WeatherApplication.Server.Models.Tenant", "Tenant")
                        .WithMany("Users")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.FiveDaysWeather", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("WeatherApplication.Server.Models.Tenant", b =>
                {
                    b.Navigation("CurrentWeatherCalls");

                    b.Navigation("FiveDaysWeatherCalls");

                    b.Navigation("Records");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
