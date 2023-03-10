// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Domain.Cagnotte", b =>
                {
                    b.Property<int>("CagnotteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateLimite")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntrepriseId")
                        .HasColumnType("integer");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<int>("SommeDemandee")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("CagnotteId");

                    b.HasIndex("EntrepriseId");

                    b.ToTable("Cagnotte");
                });

            modelBuilder.Entity("Domain.Entreprise", b =>
                {
                    b.Property<int>("EntrepriseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AdresseEntreprise")
                        .HasColumnType("text");

                    b.Property<string>("MailEntreprise")
                        .HasColumnType("text");

                    b.Property<string>("NomEntreprise")
                        .HasColumnType("text");

                    b.HasKey("EntrepriseId");

                    b.ToTable("Entreprise");
                });

            modelBuilder.Entity("Domain.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("MailParticipant")
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("Domain.Participation", b =>
                {
                    b.Property<int>("CagnotteFK")
                        .HasColumnType("integer");

                    b.Property<int>("ParticipantFK")
                        .HasColumnType("integer");

                    b.Property<int>("Montant")
                        .HasColumnType("integer");

                    b.HasKey("CagnotteFK", "ParticipantFK");

                    b.HasIndex("ParticipantFK");

                    b.ToTable("Participation");
                });

            modelBuilder.Entity("Domain.Cagnotte", b =>
                {
                    b.HasOne("Domain.Entreprise", "Entreprise")
                        .WithMany("Cagnotte")
                        .HasForeignKey("EntrepriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entreprise");
                });

            modelBuilder.Entity("Domain.Participation", b =>
                {
                    b.HasOne("Domain.Cagnotte", "Cagnotte")
                        .WithMany("Participations")
                        .HasForeignKey("CagnotteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Participant", "Participant")
                        .WithMany("Participantions")
                        .HasForeignKey("ParticipantFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cagnotte");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Domain.Cagnotte", b =>
                {
                    b.Navigation("Participations");
                });

            modelBuilder.Entity("Domain.Entreprise", b =>
                {
                    b.Navigation("Cagnotte");
                });

            modelBuilder.Entity("Domain.Participant", b =>
                {
                    b.Navigation("Participantions");
                });
#pragma warning restore 612, 618
        }
    }
}
