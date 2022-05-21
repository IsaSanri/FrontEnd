import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'changeSearchLabel'
})
export class ChangeSearchLabelPipe implements PipeTransform {

  transform(value: string): string {
    

    return value;
  }

}
