describe('Link to Biketypes api test', function () {
  it('Asses and asserts', function () {
    // Step 1. Arrange - setup initial app state
    // - visit a web page
    cy.request('POST', 'https://localhost:44334/api/BikeTypes', { bikeTypeName: 'DreamBike', BikeTypePrice: 499, BikeTypeDescription: "It will take you to the skies", Id: 5 }).then(
      (response) => {

        //redirect status code is 201CREATED
        expect(response.status).to.eq(201) // true
        expect(response.body).to.have.property('id', 5, 'bikeTypeName', 'DreamBike', 'bikeTypePrice', 499,
          'bikeTypeDescription', 'It will take you to the skies.')
      }
    )
  })
})