const SkiResort = require('./02-SkiResort.js');

const expect = require('chai').expect;

describe('Test class SkiResort', function () {
    let skiResort;

    beforeEach(function () {
        skiResort = new SkiResort('Borovets');
    });

    describe('Test Constructor', () => {
        it('Test properties', () => {
            expect(skiResort.name).to.equal('Borovets');
            expect(skiResort.voters).to.equal(0);
            expect(skiResort.hotels).to.deep.equal([]);
        });
    });

    describe('Test get bestHotel()', () => {
        it('Test no voters', () => {
            const result = skiResort.bestHotel;

            expect(result).to.equal('No votes yet');
        });

        it('Test functionality', () => {
            skiResort.build('Hotel1', 20);
            skiResort.build('Hotel2', 40);
            skiResort.leave('Hotel1', 2, 6);
            skiResort.leave('Hotel2', 4, 9);

            const result = skiResort.bestHotel;

            expect(result).to.equal('Best hotel is Hotel2 with grade 36. Available beds: 44');
        });
    });

    describe('Test build() method', () => {
        it('Test error', () => {
            const result = () => skiResort.build('', 0);

            expect(result).to.throw(Error, 'Invalid input');
        });

        it('Test functionality', () => {
            const result = skiResort.build('Hotel1', 20);

            expect(skiResort.hotels[0]).to.deep.equal({
                name: 'Hotel1',
                beds: 20,
                points: 0
            });
            expect(skiResort.hotels.length).to.equal(1);
            expect(result).to.equal('Successfully built new hotel - Hotel1');
        });
    });

    describe('Test book() method', () => {
        it('Test error', () => {
            const result = () => skiResort.book('', 0);

            expect(result).to.throw(Error, 'Invalid input');
        });

        it('Test invalid hotel error', () => {
            const result = () => skiResort.book('Error', 5);

            expect(result).to.throw(Error, 'There is no such hotel');
        });

        it('Test invalid bed count error', () => {
            skiResort.build('Hotel1', 20);
            const result = () => skiResort.book('Hotel1', 30);

            expect(result).to.throw(Error, 'There is no free space');
        });

        it('Test funcionality', () => {
            skiResort.build('Hotel1', 20);
            const result = skiResort.book('Hotel1', 5);

            expect(skiResort.hotels[0].beds).to.equal(15);
            expect(result).to.equal('Successfully booked');
        });
    });

    describe('Test leave() method', () => {
        it('Test error', () => {
            const result = () => skiResort.leave('', 0, 0);

            expect(result).to.throw(Error, 'Invalid input');
        });

        it('Test invalid hotel error', () => {
            const result = () => skiResort.leave('Error', 20, 10);

            expect(result).to.throw(Error, 'There is no such hotel');
        });

        it('Test functionality', () => {
            skiResort.build('Hotel1', 20);
            const result = skiResort.leave('Hotel1', 5, 10);

            expect(skiResort.voters).to.equal(5);
            expect(skiResort.hotels[0].beds).to.equal(25);
            expect(skiResort.hotels[0].points).to.equal(50);
            expect(result).to.equal('5 people left Hotel1 hotel');
        });
    });

    describe('Test averageGrade() method', () => {
        it('Test no voters', () => {
            const result = skiResort.averageGrade();

            expect(result).to.equal('No votes yet');
        });

        it('Test functionality', () => {
            skiResort.build('Hotel1', 20);
            skiResort.leave('Hotel1', 5, 10);
            const result = skiResort.averageGrade();

            expect(result).to.equal('Average grade: 10.00');
        });
    });
});