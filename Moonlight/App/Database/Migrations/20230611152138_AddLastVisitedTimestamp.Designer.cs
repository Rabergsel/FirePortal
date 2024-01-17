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
    [Migration("20230611152138_AddLastVisitedTimestamp")]
    partial class AddLastVisitedTimestamp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FirePortal.App.Database.Entities.CloudPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ApiUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CloudPanels");
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

                    b.Property<string>("BackgroundImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

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

            modelBuilder.Entity("FirePortal.App.Database.Entities.IpBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("IpBans");
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

            modelBuilder.Entity("FirePortal.App.Database.Entities.MySqlDatabase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WebSpaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebSpaceId");

                    b.ToTable("Databases");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.NewsEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Markdown")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("NewsEntries");
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

                    b.Property<bool>("IsCleanupException")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("MainAllocationId")
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

            modelBuilder.Entity("FirePortal.App.Database.Entities.StatisticsData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Chart")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LimitsJson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.SupportChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Attachment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsQuestion")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("SupportChatMessages");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CurrentSubscriptionId")
                        .HasColumnType("int");

                    b.Property<ulong>("DiscordId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("HasRated")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastVisitedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscriptionSince")
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

                    b.HasIndex("CurrentSubscriptionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.WebSpace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CloudPanelId")
                        .HasColumnType("int");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VHostTemplate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CloudPanelId");

                    b.HasIndex("OwnerId");

                    b.ToTable("WebSpaces");
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

            modelBuilder.Entity("FirePortal.App.Database.Entities.MySqlDatabase", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.WebSpace", "WebSpace")
                        .WithMany("Databases")
                        .HasForeignKey("WebSpaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSpace");
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
                        .HasForeignKey("MainAllocationId");

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

            modelBuilder.Entity("FirePortal.App.Database.Entities.SupportChatMessage", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.User", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.User", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.Subscription", "CurrentSubscription")
                        .WithMany()
                        .HasForeignKey("CurrentSubscriptionId");

                    b.Navigation("CurrentSubscription");
                });

            modelBuilder.Entity("FirePortal.App.Database.Entities.WebSpace", b =>
                {
                    b.HasOne("FirePortal.App.Database.Entities.CloudPanel", "CloudPanel")
                        .WithMany()
                        .HasForeignKey("CloudPanelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirePortal.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CloudPanel");

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

            modelBuilder.Entity("FirePortal.App.Database.Entities.WebSpace", b =>
                {
                    b.Navigation("Databases");
                });
#pragma warning restore 612, 618
        }
    }
}
