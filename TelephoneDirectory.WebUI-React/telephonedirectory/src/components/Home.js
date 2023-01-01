import React from "react";
import Menu from "./Menu";
import SearchBar from "./SearchBar";
const Home = () => {
  return (
    <div>
      <div className="tm-main-content" id="top">
        <Menu></Menu>
        <SearchBar></SearchBar>

        <div className="tm-section-2">
          <div className="container">
            <div className="row">
              <div className="col text-center">
                <h2 className="tm-section-title">
                  Sana yardım etmek için burdayız.
                </h2>
                <p className="tm-color-white tm-section-subtitle">
                  36.500 Aktif Numara
                </p>
                <a href="#" className="tm-color-white tm-btn-white-bordered">
                  Hadi ne duruyorsun istediğin numarayı ve konumu bul.
                </a>
              </div>
            </div>
          </div>
        </div>

        <div className="tm-section tm-position-relative">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 100 100"
            preserveAspectRatio="none"
            className="tm-section-down-arrow"
          >
            <polygon fill="#ee5057" points="0,0  100,0  50,60"></polygon>
          </svg>
          <div
            className="tm-section tm-section-pad tm-bg-gray"
            id="tm-section-4"
          >
            <div className="container">
              <div className="row">
                <div className="col-sm-12 col-md-12 col-lg-4 col-xl-4 tm-recommended-container">
                  <div className="tm-bg-white">
                    <div className="tm-bg-primary tm-sidebar-pad">
                      <h3 className="tm-color-white tm-sidebar-title">
                        Filtrele
                      </h3>
                      <p className="tm-color-white tm-margin-b-0 tm-font-light">
                        Seçimlerinize göre sonuçlar
                      </p>
                    </div>
                    <div className="tm-sidebar-pad-2">
                      <a
                        href="#"
                        className="media tm-media tm-recommended-item"
                      >
                        <img src="img/tn-img-01.jpg" alt="Image"></img>
                        <div className="media-body tm-media-body tm-bg-gray">
                          <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">
                            Europe
                          </h4>
                        </div>
                      </a>
                      <a
                        href="#"
                        className="media tm-media tm-recommended-item"
                      >
                        <img src="img/tn-img-02.jpg" alt="Image"></img>
                        <div className="media-body tm-media-body tm-bg-gray">
                          <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">
                            Asia
                          </h4>
                        </div>
                      </a>
                      <a
                        href="#"
                        className="media tm-media tm-recommended-item"
                      >
                        <img src="img/tn-img-03.jpg" alt="Image"></img>
                        <div className="media-body tm-media-body tm-bg-gray">
                          <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">
                            Africa
                          </h4>
                        </div>
                      </a>
                      <a
                        href="#"
                        className="media tm-media tm-recommended-item"
                      >
                        <img src="img/tn-img-04.jpg" alt="Image"></img>
                        <div className="media-body tm-media-body tm-bg-gray">
                          <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">
                            South America
                          </h4>
                        </div>
                      </a>
                    </div>
                  </div>
                </div>
                <div className="col-sm-12 col-md-12 col-lg-8 col-xl-8">
                  <div className="tm-article-carousel">
                    <div className="container tm-pt-3 tm-pb-4">
                      <div className="row text-center">
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">
                          <i className="fa tm-fa-6x fa-legal tm-color-primary tm-margin-b-20"></i>
                          <h3 className="tm-color-primary tm-article-title-1">
                            Level HTML Template by Tooplate website
                          </h3>
                          <p>
                            You are allowed to download, edit and use this
                            template for your business or client websites.
                          </p>
                          <a
                            href="#"
                            className="text-uppercase tm-color-primary tm-font-semibold"
                          >
                            Continue reading...
                          </a>
                        </article>
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">
                          <i className="fa tm-fa-6x fa-plane tm-color-primary tm-margin-b-20"></i>
                          <h3 className="tm-color-primary tm-article-title-1">
                            Original Website Template Producer
                          </h3>
                          <p>
                            You are NOT allowed to re-distribute the
                            downloadable template ZIP file on any website.
                          </p>
                          <a
                            href="#"
                            className="text-uppercase tm-color-primary tm-font-semibold"
                          >
                            Continue reading...
                          </a>
                        </article>
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">
                          <i className="fa tm-fa-6x fa-life-saver tm-color-primary tm-margin-b-20"></i>
                          <h3 className="tm-color-primary tm-article-title-1">
                            Contact us if you have any question
                          </h3>
                          <p>
                            If you see this template being distributed on any
                            other site, that is an illegal copy.
                          </p>
                          <a
                            href="#"
                            className="text-uppercase tm-color-primary tm-font-semibold"
                          >
                            Continue reading...
                          </a>
                        </article>
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">
                          <i className="fa tm-fa-6x fa-life-saver tm-color-primary tm-margin-b-20"></i>
                          <h3 className="tm-color-primary tm-article-title-1">
                            Contact us if you have any question
                          </h3>
                          <p>
                            If you see this template being distributed on
                            anyother site, that is an illegal copy.
                          </p>
                          <a
                            href="#"
                            className="text-uppercase tm-color-primary tm-font-semibold"
                          >
                            Continue reading...
                          </a>
                        </article>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <footer className="tm-bg-dark-blue">
          <div className="container">
            <div className="row">
              <p className="col-sm-12 text-center tm-font-light tm-color-white p-4 tm-margin-b-0">
                Copyright &copy; <span className="tm-current-year">2023</span>{" "}
                SolarTeam - Design:{" "}
                <a
                  rel="nofollow"
                  href="https://www.SolarTeam.com"
                  className="tm-color-primary tm-font-normal"
                  target="_parent"
                >
                  SolarTeam
                </a>
              </p>
            </div>
          </div>
        </footer>
      </div>
    </div>
  );
};
export default Home;
