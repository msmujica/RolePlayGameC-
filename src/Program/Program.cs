using Ucu.Poo.Roleplay;

Enano enano = new Enano("Thorin", "Masculino", 195);

Hechizos FireBall = new Hechizos("FireBall", 20);
Libros grimorio = new Libros("5 trvols");
grimorio.agregarHechizo(FireBall);
        
        
Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);
        
mago.atacarEnano(enano, FireBall);