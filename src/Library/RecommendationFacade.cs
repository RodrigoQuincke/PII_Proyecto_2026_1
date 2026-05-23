using System;
using System.Collections.Generic;

namespace Proyecto2026
{

    // Fachada del sistema de recomendaciones.
    // Ofrece una interfaz simple a un subsistema complejo (Catalog + RecommendationEngine + usuarios).
    // El cliente no necesita conocer cómo interactúan internamente estas piezas.

    public class RecommendationFacade
    {
        private Catalog catalog;
        private RecommendationEngine engine;
        private List<User> users;

        public RecommendationFacade(Catalog catalog, RecommendationEngine engine)
        {
            this.catalog = catalog;
            this.engine = engine;
            this.users = new List<User>();
        }


        // ── Usuarios ──────────────────────────────────────────────────

        // Registra un nuevo usuario (chequea que no exista previamente).

        public User RegisterUser(string username, string email, string hashedPassword)
        {
            if (UserExists(username))
                throw new InvalidOperationException($"El usuario '{username}' ya existe.");

            var user = new User(username, email, hashedPassword);
            users.Add(user);
            return user;
        }

        // Verifica si un usuario con ese nombre ya está registrado.
        public bool UserExists(string username)
        {
            return users.Exists(u => u.Username == username);
        }

        // ── Catálogo ──────────────────────────────────────────────────

        // Agrega una canción al catálogo.
        public void AddMusic(Music music)
        {
            catalog.AddItem(music);
        }

        // ── Interacciones ─────────────────────────────────────────────

        // Registra una interacción del usuario con un ítem.
        public void RegisterInteraction(User user, IContent item, InteractionType type)
        {
            var interaction = new Interaction(item, type, DateTime.Now);
            user.History.Add(interaction);
        }

        // ── Recomendaciones ───────────────────────────────────────────


        // Obtiene recomendaciones personalizadas para el usuario.
        public List<IContent> GetRecommendations(User user)
        {
            var available = catalog.GetAvailableItems();
            return engine.Recommend(user, available);
        }
    }
}