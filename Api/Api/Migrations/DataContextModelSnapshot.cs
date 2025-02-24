﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Models.ChiTietHoaDonModel", b =>
                {
                    b.Property<int>("idCTHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal?>("giaBan")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("iHD")
                        .HasColumnType("int");

                    b.Property<int?>("idHD")
                        .HasColumnType("int");

                    b.Property<int>("idSP")
                        .HasColumnType("int");

                    b.Property<int>("idSanPham")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<decimal?>("thanhTien")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("idCTHD");

                    b.HasIndex("iHD");

                    b.HasIndex("idSanPham");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("Api.Models.DanhMucModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tenDM")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("DanhMucs");
                });

            modelBuilder.Entity("Api.Models.GioHangModel", b =>
                {
                    b.Property<int>("idGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("gia")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("idSP")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("idGioHang");

                    b.HasIndex("idSP");

                    b.HasIndex("idUser");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("Api.Models.HoaDonModel", b =>
                {
                    b.Property<int>("idHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("tongTien")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("trangThaiHD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idHD");

                    b.HasIndex("idUser");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("Api.Models.SanPhamModel", b =>
                {
                    b.Property<int>("idSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("giaBan")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("idDanhMuc")
                        .HasColumnType("int");

                    b.Property<int?>("idThuongHieu")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idSP");

                    b.HasIndex("idDanhMuc");

                    b.HasIndex("idThuongHieu");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("Api.Models.ThuongHieuModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tenTH")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("Api.Models.UserModel", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("quyen")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("sdt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tenUser")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api.Models.ChiTietHoaDonModel", b =>
                {
                    b.HasOne("Api.Models.HoaDonModel", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("iHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.SanPhamModel", "SanPham")
                        .WithMany()
                        .HasForeignKey("idSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Api.Models.GioHangModel", b =>
                {
                    b.HasOne("Api.Models.SanPhamModel", "SanPham")
                        .WithMany()
                        .HasForeignKey("idSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Api.Models.HoaDonModel", b =>
                {
                    b.HasOne("Api.Models.UserModel", "Users")
                        .WithMany()
                        .HasForeignKey("idUser");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Api.Models.SanPhamModel", b =>
                {
                    b.HasOne("Api.Models.DanhMucModel", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("idDanhMuc");

                    b.HasOne("Api.Models.ThuongHieuModel", "ThuongHieu")
                        .WithMany()
                        .HasForeignKey("idThuongHieu");

                    b.Navigation("DanhMuc");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("Api.Models.HoaDonModel", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
