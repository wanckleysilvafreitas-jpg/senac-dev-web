using MeuCorre.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Infra.Data.Configurations
{
    internal class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            //Define o nome da tabela no banco de dados.
            builder.ToTable("Tags");

            //Define a chave primária.
            builder.HasKey(Tag => Tag.Id);

            //Define as propriedades da entidade e suas configurações.
            builder.Property(Tag => Tag.Nome)
                .IsRequired()
                .HasMaxLength(100);


            builder.Property(Tag => Tag.Cor)
                .HasMaxLength(10);



            builder.Property(usuario => usuario.DataCriacao)
                .IsRequired();

            builder.Property(usuario => usuario.DataAtualizacao)
                .IsRequired(false);

            //Chaves Estrangeiras FK
            //Define o relacionamento entre Tag e Usuario 
            builder.HasOne(Tag => Tag.Usuario)
                .WithMany(usuario => usuario.Tag)
                .HasForeignKey(Tag => Tag.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
