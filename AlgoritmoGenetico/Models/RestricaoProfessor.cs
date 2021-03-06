﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("tb_restricao_professor")]
    public class RestricaoProfessor
    {
        [Column("idrestricao")]
        public int Id { get; set; }
        [Column("segunda")]
        public bool Segunda { get; set; }
        [Column("terca")]
        public bool Terca { get; set; }
        [Column("quarta")]
        public bool Quarta { get; set; }
        [Column("quinta")]
        public bool Quinta { get; set; }
        [Column("sexta")]
        public bool Sexta { get; set; }
        [Column("idano")]
        public int IdAno { get; set; }
        [Column("idprofessor")]
        public int IdProfessor { get; set; }
        [ForeignKey("IdAno")]
        public virtual Ano Ano { get; set; }
        [ForeignKey("IdProfessor")]
        public virtual Professor Professor { get; set; }
    }
}
