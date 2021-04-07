"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var equipo_service_1 = require("./equipo.service");
describe('EquipoService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(equipo_service_1.EquipoService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=equipo.service.spec.js.map