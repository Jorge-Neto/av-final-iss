import amqplib from "amqplib";

var dados = [];

class FolhasController {

  inputConta(novoInput) {
    novoInput.saldo = 0;
    novoInput.movimentacoes = [];

    if (dados.length < 1) {
      dados.push(novoInput);
    } else {
      dados.forEach(conta => {
        if (conta.agencia === novoInput.agencia && conta.conta === novoInput.conta) {
          conta = novoInput;
        }
      })
    }

    return;
  }

  updateSaldo(novoValor, movimentacao) {
    dados.forEach(conta => {
      if (conta.agencia === novoValor.agencia && conta.conta === novoValor.conta) {
        if (movimentacao === "depositar") {
          conta.saldo += parseFloat(novoValor.valor);
          conta.movimentacoes.push({"depositos": novoValor.valor});
        }
        if (movimentacao === "sacar") {
          conta.saldo -= parseFloat(novoValor.valor);
          conta.movimentacoes.push({"saques": novoValor.valor});
        }
      }
    })
    return;
  }

  async saldo(req, res) {
    const { agencia, conta } = req.params;
    var resposta;

    await dados.map(valor => {
      if (valor.agencia === agencia && valor.conta === conta) {
        resposta = valor.saldo;
      }
    })

    console.log(resposta);
    res.json(resposta);
  }

  async movimentacoes(req, res) {
    const { agencia, conta } = req.params;
    var resposta;

    await dados.map(valor => {
      if (valor.agencia === agencia && valor.conta === conta) {
        resposta = valor.movimentacoes;
      }
    })

    console.log(resposta);
    res.json(resposta);
  }

}

export default new FolhasController();
