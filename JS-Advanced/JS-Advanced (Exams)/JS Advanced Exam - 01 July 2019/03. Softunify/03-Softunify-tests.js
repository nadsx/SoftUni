const SoftUniFy = require("./03-Softunify.js");

const expect = require('chai').expect;

describe('Test class SoftUniFy', function () {
    let softUni;

    beforeEach(function () {
        softUni = new SoftUniFy();
    });

    describe('Test Constructor', () => {
        it('Test property', () => {
            expect(softUni.allSongs).to.deep.equal({});
        });
    });

    describe('Test downloadSong()', () => {
        it('Add song to not existing Artist', () => {
            const result = softUni.downloadSong('Billie Eilish', 'bad guy', `I'm the bad guy..`);

            expect(result).to.deep.equal({
                allSongs: {
                    'Billie Eilish': {
                        rate: 0,
                        votes: 0,
                        songs: [`bad guy - I'm the bad guy..`]
                    }
                }
            });
        });

        it('Add song to existing Artist', () => {
            softUni.downloadSong('Billie Eilish', 'bad guy', `I'm the bad guy..`);
            const result = softUni.downloadSong('Billie Eilish', 'everything i wanted', 'I had a dream..I got everything I wanted');

            expect(result).to.deep.equal({
                allSongs: {
                    'Billie Eilish': {
                        rate: 0,
                        votes: 0,
                        songs: [`bad guy - I'm the bad guy..`, 'everything i wanted - I had a dream..I got everything I wanted']
                    }
                }
            });
        });
    });

    describe('Test playSong()', () => {
        it('Play not downloaded song', () => {
            const result = softUni.playSong('bad guy');

            expect(result).to.equal(
                `You have not downloaded a bad guy song yet. Use SoftUniFy's function downloadSong() to change that!`
            );
        });

        it('Play downloaded song', () => {
            softUni.downloadSong('Billie Eilish', 'bad guy', `I'm the bad guy..`);
            const result = softUni.playSong('bad guy');

            expect(result).to.equal(`Billie Eilish:\nbad guy - I'm the bad guy..\n`);
        });
    });

    describe('Test getter songsList', () => {
        it('Return empty list', () => {
            const result = softUni.songsList;

            expect(result).to.equal('Your song list is empty');
        });

        it('Return none empty list', () => {
            softUni.downloadSong('Billie Eilish', 'bad guy', `I'm the bad guy..`);
            softUni.downloadSong('Billie Eilish', 'everything i wanted', 'I had a dream..I got everything I wanted');
            const result = softUni.songsList;

            expect(result).to.equal(`bad guy - I'm the bad guy..\neverything i wanted - I had a dream..I got everything I wanted`);
        });
    });

    describe('Test rateArtist()', () => {
        it('Test none existing artist', () => {
            const result = softUni.rateArtist();

            expect(result).to.equal('The undefined is not on your artist list.');
        });

        it('Test existing artist', () => {
            softUni.downloadSong('Billie Eilish', 'bad guy', `I'm the bad guy..`);
            const result = softUni.rateArtist('Billie Eilish', 10);

            expect(result).to.equal(10);
        });
    });
});