using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class ParticipationConfiguration : IEntityTypeConfiguration<Participation>
    {
        public void Configure(EntityTypeBuilder<Participation> builder)
        {
            builder.HasKey(f => new
            {
             f.CagnotteFK,
             f.ParticipantFK
            });

            builder.HasOne(f => f.Cagnotte)
                .WithMany(c => c.Participations)
                .HasForeignKey(f => f.CagnotteFK);

            builder.HasOne(f => f.Participant)
                .WithMany(p => p.Participantions)
                .HasForeignKey(f => f.ParticipantFK);

        }
    }
}
