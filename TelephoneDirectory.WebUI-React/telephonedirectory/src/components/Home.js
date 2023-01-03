import React from "react";
import Footer from "./Footer";
import { Institution } from "./Institution";
import LeftFilter from "./LeftFilter";
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
                  <LeftFilter></LeftFilter>
                </div>
                <div className="col-sm-12 col-md-12 col-lg-8 col-xl-8">
                  <Institution></Institution>
                </div>
              </div>
            </div>
          </div>
        </div>
      <Footer></Footer>
      </div>
    </div>
  );
};
export default Home;
