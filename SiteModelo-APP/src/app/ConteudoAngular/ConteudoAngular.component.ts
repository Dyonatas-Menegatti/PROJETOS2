import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';


@Component({
  // tslint:disable-next-line:component-selector
  selector: 'app-ConteudoAngular',
  templateUrl: './ConteudoAngular.component.html',
  styleUrls: ['./ConteudoAngular.component.scss']
})
export class ConteudoAngularComponent implements OnInit {

  Parametro: any;

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line:typedef
  ngOnInit() {
    this.getconteudo();
  }

  // tslint:disable-next-line:typedef
  getconteudo(){
    this.http.get('http://localhost:5000/conteudo/').subscribe(response => {
      this.Parametro = response;
      console.log(response);
      // tslint:disable-next-line:no-shadowed-variable
      }, error => {console.log(error);
    }
    );
  }
}
