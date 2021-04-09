﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebTodoList.Models;

namespace WebTodoList.Migrations
{
    [DbContext(typeof(WebTodoListContext))]
    [Migration("20210409091904_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebTodoList.Models.TodayTodosDto", b =>
                {
                    b.Property<int>("Count")
                        .HasColumnType("integer")
                        .HasColumnName("count");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.ToView("View_BlogPostCounts");
                });

            modelBuilder.Entity("WebTodoList.Models.TodoItemDto", b =>
                {
                    b.Property<int>("TodoItemDtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("todo_item_dto_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("Done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("due_date");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<int>("TodoListId")
                        .HasColumnType("integer")
                        .HasColumnName("todo_list_id");

                    b.HasKey("TodoItemDtoId")
                        .HasName("pk_todo_items");

                    b.HasIndex("TodoListId")
                        .HasDatabaseName("ix_todo_items_todo_list_id");

                    b.ToTable("todo_items");
                });

            modelBuilder.Entity("WebTodoList.Models.TodoListDto", b =>
                {
                    b.Property<int>("TodoListDtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("todo_list_dto_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("TodoListDtoId")
                        .HasName("pk_todo_lists");

                    b.ToTable("todo_lists");
                });

            modelBuilder.Entity("WebTodoList.Models.TodoItemDto", b =>
                {
                    b.HasOne("WebTodoList.Models.TodoListDto", "TodoList")
                        .WithMany("TodoItems")
                        .HasForeignKey("TodoListId")
                        .HasConstraintName("fk_todo_items_todo_lists_todo_list_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TodoList");
                });

            modelBuilder.Entity("WebTodoList.Models.TodoListDto", b =>
                {
                    b.Navigation("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
