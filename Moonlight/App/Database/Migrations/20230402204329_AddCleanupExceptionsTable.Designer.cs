﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FirePortal.App.Database;

#nullable disable

namespace FirePortal.App.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230402204329_AddCleanupExceptionsTable")]
    partial class AddCleanupExceptionsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FirePortal.App.Database.Entities.AaPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BaseDomain")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AaPanels");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Database", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AaPanelId")
                        .HasColumnType("int");

                    b.Property<int>("InternalAaPanelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AaPanelId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Databases");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.DdosAttack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Data")
                        .HasColumnType("bigint");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NodeId")
                        .HasColumnType("int");

                    b.Property<bool>("Ongoing")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.ToTable("DdosAttacks");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.DockerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Default")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("DockerImages");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("SharedDomainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SharedDomainId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Allocations")
                        .HasColumnType("int");

                    b.Property<string>("ConfigFiles")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallDockerImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallEntrypoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallScript")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Startup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StartupDetection")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StopCommand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TagsJson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ImageTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ImageTags");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ImageVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("ImageVariables");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.LoadingMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("LoadingMessages");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.LogsEntries.AuditLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JsonData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("System")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AuditLog");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.LogsEntries.ErrorLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JsonData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Stacktrace")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("System")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("ErrorLog");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.LogsEntries.SecurityLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JsonData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("System")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SecurityLog");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Fqdn")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("HttpPort")
                        .HasColumnType("int");

                    b.Property<int>("FirePortalDaemonPort")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SftpPort")
                        .HasColumnType("int");

                    b.Property<bool>("Ssl")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TokenId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.NodeAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NodeId")
                        .HasColumnType("int");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.HasIndex("ServerId");

                    b.ToTable("NodeAllocations");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Notification.NotificationAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NotificationClientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotificationClientId");

                    b.ToTable("NotificationActions");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Notification.NotificationClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationClients");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Revoke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Revokes");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cpu")
                        .HasColumnType("int");

                    b.Property<long>("Disk")
                        .HasColumnType("bigint");

                    b.Property<int>("DockerImageIndex")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("Installing")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MainAllocationId")
                        .HasColumnType("int");

                    b.Property<long>("Memory")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NodeId")
                        .HasColumnType("int");

                    b.Property<string>("OverrideStartup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<bool>("Suspended")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("MainAllocationId");

                    b.HasIndex("NodeId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ServerBackup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Bytes")
                        .HasColumnType("bigint");

                    b.Property<bool>("Created")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerBackups");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ServerVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerVariables");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SharedDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CloudflareId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SharedDomains");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SellPassId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SubscriptionLimit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Cpu")
                        .HasColumnType("int");

                    b.Property<int>("Disk")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionLimits");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SupportMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsQuestion")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSupport")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("SupportMessages");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DiscordId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionDuration")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubscriptionSince")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("SupportPending")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("TokenValidTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("TotpEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TotpSecret")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Website", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AaPanelId")
                        .HasColumnType("int");

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FtpPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FtpUsername")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("InternalAaPanelId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PhpVersion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AaPanelId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Websites");
                });

            modelBuilder.Entity("FirePortal.App.Models.Misc.CleanupException", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CleanupExceptions");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Database", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.AaPanel", "AaPanel")
                        .WithMany()
                        .HasForeignKey("AaPanelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AaPanel");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.DdosAttack", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.DockerImage", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Image", null)
                        .WithMany("DockerImages")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Domain", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.SharedDomain", "SharedDomain")
                        .WithMany()
                        .HasForeignKey("SharedDomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("SharedDomain");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ImageVariable", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Image", null)
                        .WithMany("Variables")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.NodeAllocation", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Node", null)
                        .WithMany("Allocations")
                        .HasForeignKey("NodeId");

                    b.HasOne("FirePortal.App.Database.Entities.Server", null)
                        .WithMany("Allocations")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Notification.NotificationAction", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Notification.NotificationClient", "NotificationClient")
                        .WithMany()
                        .HasForeignKey("NotificationClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotificationClient");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Notification.NotificationClient", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Server", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.NodeAllocation", "MainAllocation")
                        .WithMany()
                        .HasForeignKey("MainAllocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("MainAllocation");

                    b.Navigation("Node");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ServerBackup", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Server", null)
                        .WithMany("Backups")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.ServerVariable", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Server", null)
                        .WithMany("Variables")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SubscriptionLimit", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.Subscription", null)
                        .WithMany("Limits")
                        .HasForeignKey("SubscriptionId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SupportMessage", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.User", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId");

                    b.HasOne("FirePortal.App.Database.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.User", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Website", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.AaPanel", "AaPanel")
                        .WithMany()
                        .HasForeignKey("AaPanelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AaPanel");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Image", b =>
                {
                    b.Navigation("DockerImages");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Node", b =>
                {
                    b.Navigation("Allocations");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Server", b =>
                {
                    b.Navigation("Allocations");

                    b.Navigation("Backups");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Subscription", b =>
                {
                    b.Navigation("Limits");
                });
#pragma warning restore 612, 618
        }
    }
}
