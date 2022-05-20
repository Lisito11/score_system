using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace score_system
{
    public partial class DBScoreContext : DbContext
    {
        public DBScoreContext()
        {
        }

        public DBScoreContext(DbContextOptions<DBScoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competitor> Competitors { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Reward> Rewards { get; set; } = null!;
        public virtual DbSet<Score> Scores { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competitor>(entity =>
            {
                entity.ToTable("competitor");

                entity.Property(e => e.Id)
                    .HasColumnName("competitor_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.NameCompetitor)
                    .HasMaxLength(255)
                    .HasColumnName("name_competitor");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Competitors)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_team_competitor");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.Id)
                    .HasColumnName("event_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateEnd).HasColumnName("date_end");

                entity.Property(e => e.DateStart).HasColumnName("date_start");

                entity.Property(e => e.NameEvent)
                    .HasMaxLength(255)
                    .HasColumnName("name_event");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Reward)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.RewardId)
                    .HasConstraintName("fk_reward_event");
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.ToTable("reward");

                entity.Property(e => e.Id)
                    .HasColumnName("reward_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NameReward)
                    .HasMaxLength(255)
                    .HasColumnName("name_reward");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.ToTable("score");

                entity.Property(e => e.Id)
                    .HasColumnName("score_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CompetitorId).HasColumnName("competitor_id");

                entity.Property(e => e.DateScore).HasColumnName("date_score");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Score1).HasColumnName("score");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Competitor)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.CompetitorId)
                    .HasConstraintName("fk_score_competitor");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("fk_score_event");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("team");

                entity.Property(e => e.Id)
                    .HasColumnName("team_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NameTeam)
                    .HasMaxLength(255)
                    .HasColumnName("name_team");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
