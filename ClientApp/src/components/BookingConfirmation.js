import React, { Component, useState } from 'react';
import './BookingConfirmation.css'
//import './BookingForm'

export class BookingConfirmation extends Component {
  static displayName = BookingConfirmation.name;


  render() {
    return (
      <body>
        
        <div>
          <div className="a">Tack för din bokning!</div>
          Du kommer få en bokningsbekräftelse till mejladressen du angivit du angivit inom 5 minuter.


        </div>
      </body>
        

      )
  }
}
  export default BookingConfirmation;