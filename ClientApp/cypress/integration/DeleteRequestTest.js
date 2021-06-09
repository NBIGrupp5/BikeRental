describe('Link to Biketypes api test', function () {
  it('Asses and asserts', function () {

    cy.request('DELETE', 'https://localhost:44334/api/BikeTypes/5').then(
      (response) => {

        // response.body is automatically serialized into JSON
        expect(response.status).to.eq(200)
      }
    )
  })
  })