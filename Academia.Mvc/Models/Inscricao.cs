namespace Academia;

public class Inscricao
{
    public int Id {get; set;}
    public DateTime DataInscricao {get; set;} // Data de inscrição

    public string? AlunoId {get; set;} // Id do aluno associado à inscrição
    public Aluno? Aluno {get; set;} // Referência do aluno associado à inscrição (opcional)

    public string? AulaId {get; set;} // Id do aula associado à inscrição
    public Aula? Aula {get; set;} // Referência do aula associado à inscrição (opcional)
}
