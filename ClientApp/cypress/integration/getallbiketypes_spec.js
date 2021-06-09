describe('Get all BikeTypes', function () {
    it('Requests and asserts', function () {
        cy.request({
            url: 'https://localhost:44334/BikeTypes',
            followRedirect: false, // turn off following redirects
        }).then((resp) => {
            // redirect status code is 200OK
            expect(resp.status).to.eq(200)
        })
    })
})
