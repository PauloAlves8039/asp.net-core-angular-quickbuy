/**
 * @file login.component.ts
 * @author: Paulo Alves
 * @description: componente responsável pelo login do usuário na aplicação.
 * @version 1.0.1 (05/10/2020)
 */

import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

/**
 * Classe responsável por definir as propriedades do Login.
 */
@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public usuario;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar(): void {
    alert(this.usuario.email + ' - ' + this.usuario.senha);
  }
}
