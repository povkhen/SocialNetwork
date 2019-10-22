﻿// <auto-generated />
using Messager.Data.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Messager.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Messager.Data.Models.Conversations.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("NickName");

                    b.HasKey("Id");

                    b.ToTable("Conversations");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Conversation");
                });

            modelBuilder.Entity("Messager.Data.Models.Messages.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConversationId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("SenderId");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Message");
                });

            modelBuilder.Entity("Messager.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("NickName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Messager.Data.Models.UserConversation", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("ConversationId");

                    b.HasKey("UserId", "ConversationId");

                    b.HasIndex("ConversationId");

                    b.ToTable("UserConversations");
                });

            modelBuilder.Entity("Messager.Data.Models.Conversations.Dialogue", b =>
                {
                    b.HasBaseType("Messager.Data.Models.Conversations.Conversation");


                    b.ToTable("Dialogue");

                    b.HasDiscriminator().HasValue("Dialogue");
                });

            modelBuilder.Entity("Messager.Data.Models.Messages.TextMessage", b =>
                {
                    b.HasBaseType("Messager.Data.Models.Messages.Message");

                    b.Property<string>("Text");

                    b.ToTable("TextMessage");

                    b.HasDiscriminator().HasValue("TextMessage");
                });

            modelBuilder.Entity("Messager.Data.Models.Messages.Message", b =>
                {
                    b.HasOne("Messager.Data.Models.Conversations.Conversation", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Messager.Data.Models.User", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Messager.Data.Models.UserConversation", b =>
                {
                    b.HasOne("Messager.Data.Models.Conversations.Conversation", "Conversation")
                        .WithMany("Members")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Messager.Data.Models.User", "User")
                        .WithMany("Conversations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
