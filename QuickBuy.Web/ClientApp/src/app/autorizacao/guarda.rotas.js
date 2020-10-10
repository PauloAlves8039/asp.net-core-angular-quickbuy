"use strict";
/**
 * @file guarda.rotas.ts
 * @author: Paulo Alves
 * @description: responsável por gerenciar a autenticação do usuário ao acessar algumas rotas da aplicação.
 * @version 1.0.1 (10/10/2020)
 */
Object.defineProperty(exports, "__esModule", { value: true });
/**
 * Classe responsável pela autenticação do usuário.
 */
var GuardaRotas = /** @class */ (function () {
    function GuardaRotas() {
    }
    GuardaRotas.prototype.canActivate = function (route, state) {
        return true;
    };
    return GuardaRotas;
}());
exports.GuardaRotas = GuardaRotas;
//# sourceMappingURL=guarda.rotas.js.map