/**
 * @file usuario.ts
 * @author: Paulo Alves
 * @description: responsável por definir modelo lógico para a entidade Usuario.
 * @version 1.0.1 (06/10/2020)
 */

/**
 * Classe resposável pela atribuição de propriedades referentes a entidade Usuario.
 */
export class Usuario {
  id: number;
  email: string;
  senha: string;
  nome: string;
  sobrenome: string;
}
