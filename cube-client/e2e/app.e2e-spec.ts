import { CubeClientPage } from './app.po';

describe('cube-client App', function() {
  let page: CubeClientPage;

  beforeEach(() => {
    page = new CubeClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
