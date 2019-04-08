using System;
using System.Windows.Forms;

public class ListaSimples
{
    private Celula primeiro, ultimo, anterior, atual;
    int quantosNos;

    private bool primeiroAcessoDoPercurso;

    public ListaSimples()
    {
        primeiro = ultimo = anterior = atual = null;
        quantosNos = 0;
        primeiroAcessoDoPercurso = false;
    }
    public void percorrerLista()
    {
        atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Prox;
        }
    }

    public bool EstaVazia
    {
        get => primeiro == null;
    }
    public Celula Primeiro { get => primeiro; }
    public Celula Ultimo { get => ultimo; }
    public int QuantosNos { get => quantosNos; }
    public Celula Atual { get => atual; set => atual = value; }

    public void InserirAntesDoInicio(Celula novoNo)
    {
        if (EstaVazia)
            ultimo = novoNo;
        novoNo.Prox = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(int Valorrmacao)
    {
        if (Valorrmacao != null)
        {
            var novoNo = new Celula(Valorrmacao, null);
            InserirAntesDoInicio(novoNo);
        }
    }

    public void InserirAposFim(Celula novaCelula)
    {
        if (EstaVazia)
            primeiro = novaCelula;
        else
            ultimo.Prox = novaCelula;
        novaCelula.Prox = null;
        ultimo = novaCelula;
        quantosNos++;
    }

    public void InserirAposFim(int Valorrmacao)
    {
        if (Valorrmacao != null)
        {
            var novoNo = new Celula(Valorrmacao, null);
            InserirAposFim(novoNo);
        }
    }

    public void Exibir(DataGridView onde)
    {
        onde.Clear();

        for (atual = primeiro; atual != null; atual = atual.Prox)
            onde.Add(atual.Valor);

        // ou
        // atual = primeiro;
        // while (atual != null)
        // {
        //    onde.Items.Add(atual.Valor);
        //    atual = atual.Prox;
        // }
    }

  publicbool Existeint(int outroProcurado)
  {
    anterior = null;
    atual = primeiro;

    // Em seguida, é verificado se a lista está vazia. Caso esteja, é
    // retornado false ao local de chamada, indicando que a chave não foi
    // encontrada, e atual e anterior ficam valendo null

    if (EstaVazia)
      return false;

    // a lista não está vazia, possui nós
    // int procurado é menor que o primeiro int da lista:
    // portanto, int procurado não existe

    if (outroProcurado.CompareTo(primeiro.Valor) < 0)
      return false;

    // int procurado é maior que o último int da lista:
    // portanto, int procurado não existe

    if (outroProcurado.CompareTo(ultimo.Valor) > 0)
    {
      anterior = ultimo;
      atual = null;
      return false;
    }

    // caso não tenha sido definido que a chave está fora dos limites de
    // chaves da lista, vamos procurar no seu interior

    // o apontador atual indica o primeiro nó da lista e consideraremos que
    // ainda não achou a chave procurada nem chegamos ao final da lista

    bool achou = false;
    bool fim = false;

    // repete os comandos abaixo enquanto não achou o RA nem chegou ao
    // final da lista
    while (!achou && !fim)
    {
      // se o apontador atual vale null, indica final da lista
      if (atual == null)
        fim = true;

      // se não chegou ao final da lista, verifica o valor da chave atual
      else
      // verifica igualdade entre chave procurada e chave do nó atual
      if (outroProcurado.CompareTo(atual.Valor) == 0)
        achou = true;
      else
      // se chave atual é maior que a procurada, significa que
      // a chave procurada não existe na lista ordenada e, assim,
      // termina a pesquisa indicando que não achou. Anterior
      // aponta o anterior ao atual, que foi acessado por
      // último
      if (atual.Valor.CompareTo(outroProcurado) > 0)
        fim = true;
      else
      {
        // se não achou a chave procurada nem uma chave > que ela,
        // então a pesquisa continua, de maneira que o apontador
        // anterior deve apontar o nó atual e o apontador atual
        // deve seguir para o nó seguinte
        anterior = atual;
        atual = atual.Prox;
      }
    }
    // por fim, caso a pesquisa tenha terminado, o apontador atual
    // aponta o nó onde está a chave procurada, caso ela tenha sido
    // encontrada, ou o nó onde ela deveria estar para manter a
    // ordenação da lista. O apontador anterior aponta o nó anterior
    // ao atual
    return achou; // devolve o valor da variável achou, que indica
                  // se a chave procurada foi ou não encontrado
}

  public void InserirEmOrdem(int ints)
  {
    if (!Existeint(ints)) // existeint configurou anterior e atual
    {                       // aqui temos certeza de que a chave não existe
      Celula novo = new Celula(ints, null); // guarda ints no
                                                     // novo nó
      if (EstaVazia) // se a lista está vazia, então o
        InserirAntesDoInicio(novo); // novo nó é o primeiro da lista
      else
      if (anterior == null && atual != null)
        InserirAntesDoInicio(novo); // liga novo antes do primeiro
      else
        InserirNoMeio(novo); // insere entre os nós anterior e atual
    }
  }
  private void InserirNoMeio(Celula novo)
  {
    // existeint() encontrou intervalo de inclusão do novo nó
    anterior.Prox = novo; // liga anterior ao novo
    novo.Prox = atual; // e novo no atual
    if (anterior == ultimo) // se incluiu ao final da lista,
      ultimo = novo; // atualiza o apontador ultimo
    quantosNos++; // incrementa número de nós da lista
  }

  public bool Remover(int ints)
  {
    if (!Existeint(ints))  // ajusta ponteiros atual e anterior
       return false;

    // aqui, temos certeza de que a lista não está vazia, 
    // que o int procurado existe, e seu
    // nó é apontado pelo atributo atual. 
    // O nó anterior é apontado pelo atributo anterior.

    RemoverNo(anterior, atual);

    return true;
  }
  private void RemoverNo(Celula anterior, Celula atual)
  {
    if (anterior == null && atual != null) // o procurado é o 1o nó
    {
      primeiro = atual.Prox;
      if (primeiro == null) // lista ficou vazia
        ultimo = null;      // ajustamos ultimo para não ficar lixo
    }
    else
    {
      anterior.Prox = atual.Prox;
      if (atual == ultimo)
        ultimo = anterior;
    }
    quantosNos--;
  }

  private void ProcurarMenor(ref Celula antM, 
                             ref Celula atuM)
  {
    antM = anterior = null;
    atuM = atual = primeiro;
    while (atual != null)
    {
      if (atual.Valor.CompareTo(atuM.Valor) < 0 )
      {
        antM = anterior;
        atuM = atual;
      }
      anterior = atual;
      atual = atual.Prox;
    }
  }
  public void Ordenar()
  {
    Celula menor = null, antMenor = null, noAIncluir = null;
    var listaOrdenada = new ListaSimples();
    while (!this.EstaVazia)
    {
      ProcurarMenor(ref antMenor, ref menor);
      noAIncluir = menor;  // reaproveitamos os nós da lista original
      this.RemoverNo(antMenor, menor);
      listaOrdenada.InserirAposFim(noAIncluir);
    }
    this.primeiro = listaOrdenada.primeiro;
    this.ultimo = listaOrdenada.ultimo;
    this.quantosNos = listaOrdenada.quantosNos;
    this.atual = this.anterior = null;
  }

  //////////////////////////////////////////////////////////////////
  // Exercícios
  //////////////////////////////////////////////////////////////////

  // Exercício 1: percorrer e contar nós
  public int Contar()
    {
        int quantos = 0;
        atual = primeiro;
        while (atual != null)
        {
            quantos++;
            atual = atual.Prox;
        }
        return quantos;
    }
    // Exercicio 3 : unir duas listas ligadas numa terceira

    public ListaSimples UnirCom(ListaSimples outra)
    {
        ListaSimples novaLista = new ListaSimples();
        atual = primeiro;
        outra.atual = outra.primeiro;
        while (atual != null && outra.atual != null)
        {
            if (atual.Valor.CompareTo(outra.atual.Valor) < 0)
            {
                novaLista.InserirAposFim(atual.Valor);
                atual = atual.Prox;
            }
            else
              if (outra.atual.Valor.CompareTo(atual.Valor) < 0)
            {
                novaLista.InserirAposFim(outra.atual.Valor);
                outra.atual = outra.atual.Prox;
            }
            else
            {
                novaLista.InserirAposFim(atual.Valor);
                outra.atual = outra.atual.Prox;
                atual = atual.Prox;
            }

        }

        // se a lista this ainda não foi percorrida até o final,
        // terminamos de percorrê-la e incluímos os elementos 
        // faltantes na lista de união (novaLista)
        while (atual != null)
        {
            novaLista.InserirAposFim(atual.Valor);
            atual = atual.Prox;
        }

        // se a outra lista ainda não foi percorrida até o final,
        // terminamos de percorrê-la e incluímos os elementos 
        // faltantes na lista de união (novaLista)
        while (outra.atual != null)
        {
            novaLista.InserirAposFim(outra.atual.Valor);
            outra.atual = outra.atual.Prox;
        }

        return novaLista;
    }
    // Exercício 4 : inverter uma lista ligada

    public void Inverter()
    {
        if (!EstaVazia)
        {
            Celula um, dois, tres;
            um = primeiro;
            dois = um.Prox;
            while (dois != null)
            {
                tres = dois.Prox;
                dois.Prox = um;
                um = dois;
                dois = tres;
            }
            ultimo = primeiro;
            primeiro = um;
            ultimo.Prox = null;
        }
    }
}

