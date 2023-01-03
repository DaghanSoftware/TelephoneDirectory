import React from 'react'

 const LeftFilter = () => {
  return (
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
  )
}
export default LeftFilter;
