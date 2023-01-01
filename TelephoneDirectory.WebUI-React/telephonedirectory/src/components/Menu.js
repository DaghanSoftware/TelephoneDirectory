import React from "react";

const Menu = () => {
  return (
    <div className="tm-top-bar" id="tm-top-bar">
      {/* <div className="tm-top-bar-bg"></div> */}
      <div className="container">
        <div className="row">
          <nav className="navbar navbar-expand-lg narbar-light">
            <a className="navbar-brand mr-auto" href="#">
              <img src="img/logo.png" alt="Site logo"></img>
              Level
            </a>
            <button
              type="button"
              id="nav-toggle"
              className="navbar-toggler collapsed"
              data-toggle="collapse"
              data-target="#mainNav"
              aria-expanded="false"
              aria-label="Toggle navigation"
            >
              <span className="navbar-toggler-icon"></span>
            </button>
            <div id="mainNav" className="collapse navbar-collapse tm-bg-white">
              <ul className="navbar-nav ml-auto">
                <li className="nav-item">
                  <a className="nav-link" href="#top">
                    Anasayfa <span className="sr-only">(current)</span>
                  </a>
                </li>
                <li className="nav-item">
                  <a className="nav-link" href="#tm-section-4">
                    Numaralar
                  </a>
                </li>
              </ul>
            </div>
          </nav>
        </div>
      </div>
    </div>
  );
};
export default Menu;