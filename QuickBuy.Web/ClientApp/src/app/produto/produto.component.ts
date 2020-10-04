/**
 * @file produto.component.ts
 * @author: Paulo Alves
 * @description: componente responsável pelas funcionalidades referentes a entidade Produto.
 * @version 1.0.1 (04/10/2020)
 */

import { Component } from "@angular/core";

/**
 * Classe responsável por definir as propriedades da entidade Produto.
 */
@Component({
  selector: "produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent {
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }
}
