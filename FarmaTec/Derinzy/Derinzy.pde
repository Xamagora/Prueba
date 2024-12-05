void setup()
{
  // Tamaño de la ventana
  size(800, 800);
}
void draw()
{
  // Cabeza
  strokeWeight(2);
  fill(#468DC1);
  stroke(#2F59EA);
  rect(300, 100, 150, 150);
  rect(300, 125, 150, 50);
  rect(325, 200, 100, 25);
  for( int i=325; i<425; i+=25) {
  line(i, 200, i, 225);   }
  strokeWeight(2);
  fill(#2F59EA);
  stroke(#2F59EA);
  ellipse (335, 150, 25, 25);
  ellipse ( 415, 150, 25, 25);
  strokeWeight(2);
  fill(#468DC1);
  stroke(#2F59EA);
  arc (300,170,80,90,HALF_PI,PI+HALF_PI);
  arc (451,170,80,90,PI+HALF_PI,TWO_PI+HALF_PI);
  //CUELLO
  rect(350, 250, 50, 25);
  rect(325, 275, 100, 25);
  //Pecho
  rect( 287, 300, 176, 176);
  rect( 312, 325, 130, 130);
  quad( 312, 390, 377, 325, 442, 390, 377, 455);
  line( 362, 375, 392, 405); // "X" de xaxiry
  line( 392, 375, 362, 405);
  // BRAZOS
  rect( 465, 300, 60, 60);
  ellipse( 495, 330, 20, 20);
  rect( 225, 300, 60, 60);
  ellipse( 255, 330, 20, 20);
  
  rect( 225, 360, 50, 140);
  fill(#6D4AD8);
  rect( 225, 400, 50, 25);
  fill(#468DC1);
  
  rect( 475, 360, 50, 140);
  fill(#6D4AD8);
  rect( 475, 400, 50, 25);
  // Manos
  fill(#6D4AD8);
  arc( 250, 500, 50, 50, 0, PI);
  arc( 500, 500, 50, 50, 0, PI);
  fill(#468DC1);
  //PIERNAS
  rect( 287, 476, 176, 24);
  triangle( 287, 500, 463, 500, 375, 550);
  line( 287, 500, 287, 725);
  line( 375, 550, 375, 725);
  line( 463, 500, 463, 725);
  line( 287, 725, 463, 725);
  rect( 287, 600, 88, 25);
  rect( 375, 600, 88, 25);
  
  // tenis
  arc( 331, 700, 100, 100, PI, TWO_PI);
  arc( 419, 700, 100, 100, PI, TWO_PI);
  
  //MORDISCO
  strokeWeight(2);
  fill(#65D8BA);
  stroke(#0E5845);
  arc( 375, 100, 100, 100, PI, TWO_PI);
  for( int i=325; i<425; i+=25) {
  line(i, 90, i+25, 110);   }
  line(425,90,400,110);
  line(400,90,375,110);
  line(375,90,350,110);
  line(350,90,325,110);
  ellipse( 350, 75, 10, 10);
  ellipse( 400, 75, 10, 10);
  line(350,50,325,25);
  line(400,50,425,25);
  
  // CREADO POR: GONZÁLEZ RAMOS XAXIRY MAGALY
  //GRUPO: 6IM14
  
  
}
