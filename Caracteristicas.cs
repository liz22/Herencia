using System;
namespace Herencia
{

		public class Caracteristicas
		{

			public string Color;
			public string interior;
			public string rines;
			public string colorrines;


			public  Caracteristicas()
			
			{
				this.Color = "Moto color Blanco";
				this.interior = "Interior: Negro, piel";
				this.rines = "Rin de Kasu";
				this.colorrines = "Color de rin Negro";
			
			}
				public virtual String caracteristicas()
				{
				
					return 

						this.colorrines + this.Color + this.rines + this.interior; 
				
				}
							
		}
}
	



