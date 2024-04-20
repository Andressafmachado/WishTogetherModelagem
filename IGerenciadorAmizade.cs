namespace Application;
public interface IGerenciadorAmizade
{
   Amizade Solicitar(Usuario eu, Usuario destinatario);
   void Confirmar(Usuario eu);
   void Rejeitar(Usuario eu);
   Amizade Cancelar(usuario eu, usuario destinatario);
   List<Usuario> ListarMeusAmigos(Usuario eu);
}