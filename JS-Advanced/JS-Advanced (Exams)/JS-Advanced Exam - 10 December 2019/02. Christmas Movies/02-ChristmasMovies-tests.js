const ChristmasMovies = require("./02-ChristmasMovies.js");

const expect = require('chai').expect;

describe('Test class ChristmasMovies', function () {
    let christmasMovies;
    let movie = 'Suicide Squad';
    let actors = ['Margot Robbie', 'Jared Leto'];
    let testUniqueActors = ['Margot Robbie', 'Jared Leto', 'Jared Leto'];
    let movie2 = 'Birds of Prey';
    let actors2 = ['Margot Robbie'];

    beforeEach(function () {
        christmasMovies = new ChristmasMovies();
    });

    describe('Test Constructor', () => {
        it('Test properties', () => {
            expect(christmasMovies.movieCollection).to.deep.equal([]);
            expect(christmasMovies.watched).to.deep.equal({});
            expect(christmasMovies.actors).to.deep.equal([]);
        });
    });

    describe('Test buyMovie()', () => {
        it('Test error message', () => {
            christmasMovies.buyMovie(movie, actors);
            const result = () => christmasMovies.buyMovie(movie, actors);

            expect(result).to.throw(Error, 'You already own Suicide Squad in your collection!');
        });

        it('Test functionality', () => {
            const result = christmasMovies.buyMovie(movie, testUniqueActors);

            expect(christmasMovies.movieCollection[0]).to.deep.equal({
                name: 'Suicide Squad',
                actors: ['Margot Robbie', 'Jared Leto']
            });
            expect(christmasMovies.movieCollection.length).to.equal(1);
            expect(christmasMovies.movieCollection[0].actors).to.deep.equal(['Margot Robbie', 'Jared Leto']);
            expect(christmasMovies.movieCollection[0].actors.length).to.equal(2);
            expect(result).to.equal('You just got Suicide Squad to your collection in which Margot Robbie, Jared Leto are taking part!');
        });
    });

    describe('Test discardMovie()', () => {
        it('Test not at your collection error message', () => {
            const result = () => christmasMovies.discardMovie('Error');

            expect(result).to.throw(Error, 'Error is not at your collection!');
        });

        it('Test not watched error message', () => {
            christmasMovies.buyMovie(movie, actors);

            const result = () => christmasMovies.discardMovie(movie);
            expect(result).to.throw(Error, 'Suicide Squad is not watched!');
        });

        it('Test functionality', () => {
            christmasMovies.buyMovie(movie, actors);
            christmasMovies.watchMovie(movie);

            const result = christmasMovies.discardMovie(movie);
            expect(result).to.equal('You just threw away Suicide Squad!');
            expect(christmasMovies.movieCollection.length).to.equal(0);
            expect(christmasMovies.movieCollection[0]).not.deep.equal({
                name: 'Suicide Squad',
                actors: ['Margot Robbie', 'Jared Leto']
            });
            expect(christmasMovies.watched).to.deep.equal({});
        });
    });

    describe('Test watchMovie()', () => {
        it('Test error message', () => {
            const result = () => christmasMovies.watchMovie('Error');

            expect(result).to.throw(Error, 'No such movie in your collection!');
        });

        it('Test watch movie single time', () => {
            christmasMovies.buyMovie(movie, actors);
            christmasMovies.watchMovie(movie);

            expect(christmasMovies.watched['Suicide Squad']).to.equal(1);
        });

        it('Test watch movie multiply times', () => {
            christmasMovies.buyMovie(movie, actors);
            christmasMovies.watchMovie(movie);
            christmasMovies.watchMovie(movie);

            expect(christmasMovies.watched['Suicide Squad']).to.equal(2);
        });
    });

    describe('Test favouriteMovie()', () => {
        it('Test error message', () => {
            const result = () => christmasMovies.favouriteMovie();

            expect(result).to.throw(Error, 'You have not watched a movie yet this year!');
        });

        it('Test functionality', () => {
            christmasMovies.buyMovie(movie, actors);
            christmasMovies.buyMovie(movie2, actors2);
            christmasMovies.watchMovie(movie);
            christmasMovies.watchMovie(movie2);
            christmasMovies.watchMovie(movie);

            const result = christmasMovies.favouriteMovie();

            expect(result).to.equal('Your favourite movie is Suicide Squad and you have watched it 2 times!');
        });
    });

    describe('Test mostStarredActor()', () => {
        it('Test error message', () => {
            const result = () => christmasMovies.mostStarredActor();

            expect(result).to.throw(Error, 'You have not watched a movie yet this year!');
        });

        it('Test functionality', () => {
            christmasMovies.buyMovie(movie, actors);
            christmasMovies.buyMovie(movie2, actors2);

            const result = christmasMovies.mostStarredActor();

            expect(result).to.equal('The most starred actor is Margot Robbie and starred in 2 movies!');
        });
    });
});