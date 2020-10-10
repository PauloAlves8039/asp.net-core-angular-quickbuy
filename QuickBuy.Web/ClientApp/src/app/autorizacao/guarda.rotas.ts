/**
 * @file guarda.rotas.ts
 * @author: Paulo Alves
 * @description: responsável por gerenciar a autenticação do usuário ao acessar algumas rotas da aplicação.
 * @version 1.0.1 (10/10/2020)
 */

import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

/**
 * Classe responsável pela autenticação do usuário.
 */
@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    this.router.navigate(['/entrar']);
    return false;
  }
}
