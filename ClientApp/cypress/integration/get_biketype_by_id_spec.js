describe('Get BikeType by Id', function () {
    it('Requests and asserts', function () {
        cy.request('https://localhost:44334/api/BikeTypes/1')
            .then((response) => {
            // redirect status code is 200OK
            expect(response.status).to.eq(200)
            expect(response.body).to.have.property('id', 1, 'bikeTypeName', 'Elcykel', 'bikeTypePrice', 299,
                    'bikeTypeDescription', 'Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna.Elmotorn hjälper dig upp till 25km / h.',
                    'bikeTypeImage', 'https://www.electricbike.com/wp-content/uploads/2020/08/Celebrity3.jpg')
        })
    })
})