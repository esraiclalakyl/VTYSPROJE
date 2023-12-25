CREATE DATABASE "Bisiklet_Paylasim_Sistemi"
ENCODING='UTF-8'
LC_COLLATE='tr_TR.UTF-8'
LC_CTYPE='tr_TR.UTF-8'	
OWNER postgres
TEMPLATE=template0;

CREATE SCHEMA "public";

CREATE TABLE "bike_types" (
  "id" integer,
  "type_name" varchar(30),
  "brand" varchar(20),
  PRIMARY KEY ("id")
);

CREATE TABLE "users" (
  "user_id" integer,
  "first_name" varchar(40),
  "last_name" varchar(40),
  "phone" varchar(10),
  "address" varchar,
  "user_type" varchar(20) NOT NULL,
  PRIMARY KEY ("user_id")
);

CREATE TABLE "payment_info" (
  "id" integer,
  "user_id" integer,
  "card_no" varchar(16),
  "skt" varchar,
  "cvc" varchar(3),
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_payment_info.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
);

CREATE TABLE "user_ratings" (
  "id" integer,
  "user_id" integer,
  "point" varchar(1),
  "comment" text,
  "date" timestamp,
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_user_ratings.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
);

CREATE TABLE "bs_status" (
  "status_id" integer,
  "status_name" varchar(40),
   PRIMARY KEY ("status_id")
);

CREATE TABLE "bike_stations" (
  "station_id" integer,
  "station_name" varchar(70),
  "capacity" integer,
  "location" varchar,
   PRIMARY KEY ("station_id")
);

CREATE TABLE "station_reviews" (
  "id" integer,
  "user_id" integer,
  "station_id" integer,
  "content" varchar(50),
  "date" timestamp,
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_station_reviews.station_id"
    FOREIGN KEY ("station_id")
      REFERENCES "bike_stations"("station_id"),
  CONSTRAINT "FK_station_reviews.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
);

CREATE TABLE "promotions" (
  "promotion_id" integer,
  "name" varchar(50),
  "discount" integer,
  PRIMARY KEY ("promotion_id")
);

CREATE TABLE "premium_users" (
  "user_id" integer,
  "promotion_id" integer,
  "pre_level" varchar(10),
  PRIMARY KEY ("user_id"),
  CONSTRAINT "FK_premium_users.promotion_id"
    FOREIGN KEY ("promotion_id")
      REFERENCES "promotions"("promotion_id"),
	CONSTRAINT "FK_premium_users.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE "request_type" (
  "type_id" integer,
  "type" varchar(50),
  PRIMARY KEY ("type_id")
);

CREATE TABLE "user_requests" (
  "id" integer,
  "user_id" integer,
  "type_id" integer,
  "explanation" text,
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_user_requests.type_id"
    FOREIGN KEY ("type_id")
      REFERENCES "request_type"("type_id"),
  CONSTRAINT "FK_user_requests.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
);

CREATE TABLE "bikes" (
  "bike_id" integer,
  "station_id" integer,
  "bike_type_id" integer,
  "status" varchar(20),
  PRIMARY KEY ("bike_id"),
  CONSTRAINT "FK_bikes.bike_type_id"
    FOREIGN KEY ("bike_type_id")
      REFERENCES "bike_types"("id"),
  CONSTRAINT "FK_bikes.station_id"
    FOREIGN KEY ("station_id")
      REFERENCES "bike_stations"("station_id")
);

CREATE TABLE "rentals" (
  "rental_id" integer,
  "user_id" integer,
  "bike_id" integer,
  "start_time" time,
  "end_time" time,
  "total_cost" money,
  "date" date,
  "is_over" boolean,
  PRIMARY KEY ("rental_id"),
  CONSTRAINT "FK_rentals.bike_id"
    FOREIGN KEY ("bike_id")
      REFERENCES "bikes"("bike_id"),
  CONSTRAINT "FK_rentals.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
);

CREATE TABLE "regular_users" (
  "user_id" integer,
  "regular_level" varchar(10),
  PRIMARY KEY ("user_id"),
CONSTRAINT "FK_regular_users.user_id"
    FOREIGN KEY ("user_id")
      REFERENCES "users"("user_id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE "maintenance_history" (
  "id" integer,
  "bike_id" integer,
  "m_type" varchar(50),
  "m_date" date,
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_maintenance_history.bike_id"
    FOREIGN KEY ("bike_id")
      REFERENCES "bikes"("bike_id")
);

CREATE TABLE "bs_status_history" (
  "id" integer,
  "status_id" integer,
  "station_id" integer,
  "date_and_time" timestamp,
  PRIMARY KEY ("id"),
  CONSTRAINT "FK_bs_status_history.status_id"
    FOREIGN KEY ("status_id")
      REFERENCES "bs_status"("status_id"),
  CONSTRAINT "FK_bs_status_history.station_id"
    FOREIGN KEY ("station_id")
      REFERENCES "bike_stations"("station_id")
);


-- BikeTypes
INSERT INTO "bike_types" ("id", "type_name", "brand") VALUES
  (1, 'Elektrikli Bisiklet', 'Bosch'),
  (2, 'Şehir Bisikleti', 'Trek'),
  (3, 'Elektrikli Bisiklet', 'Haibike'),
  (4, 'Şehir Bisikleti', 'Specialized');
  

-- Users
INSERT INTO "users" ("user_id", "first_name", "last_name", "phone", "address", "user_type") VALUES
  (1, 'Selim', 'Kaya', '1234567890', 'İnönü, Ataşehir/İstanbul', 'Regular'),
  (2, 'Büşra', 'Durgun', '9876543210', 'Suadiye, Kadıköy/İstanbul', 'Premium'),
  (3, 'Sevgi', 'Gedik', '9876543210', 'Göztepe, Kadıköy/İstanbul', 'Premium'),
  (4, 'Alican', 'Korkmaz', '9876543210', 'Osmanağa, Kadıköy/İstanbul', 'Regular'),
  (5, 'Mehtap', 'Gürsoy', '9876543210', 'Osmanağa, Kadıköy/İstanbul', 'Regular'),
  (6, 'Kumru', 'Göğebakan', '9876543210', 'Rasimpaşa, Kadıköy/İstanbul', 'Premium');
  INSERT INTO "users" ("user_id", "first_name", "last_name", "phone", "address", "user_type") VALUES
  (8, 'sadada', 'döğeGDFkan', '9876543210', 'Rasimpaşa, Kadıköy/İstanbul', 'Premium');
  
  
  
  
  

-- PaymentInfo
INSERT INTO "payment_info" ("id", "user_id", "card_no", "skt", "cvc") VALUES
  (1, 4, '1234567890123456', '03/25', '604'),
  (2, 3, '9876543210987654', '06/26', '632'),
  (3, 2, '9876543210987654', '06/26', '414'),
  (4, 1, '9876543210987654', '08/27', '223'),
  (5, 6, '9876543210987654', '07/24', '596'),
  (6, 5, '9876543210987654', '05/28', '908');
  

-- UserRatings
INSERT INTO "user_ratings" ("id", "user_id", "point", "comment", "date") VALUES
  (1, 1, '5', 'Uygulamadan memnunum!', '2023-02-05 12:34:56'),
  (2, 2, '2', 'Bisiklet sayısı az.', '2023-01-14 07:30:45'),
  (3, 3, '4', 'Bisikletler çok kullanışlı.', '2023-11-05 10:23:45');
  

-- BSStatus
INSERT INTO "bs_status" ("status_id", "status_name") VALUES
  (1, 'Bakımda, kullanılamaz'),
  (2, 'Bisiklet var, kullanılabilir'),
  (3, 'Bisiklet yok, kullanılabilir');
  

-- BikeStations
INSERT INTO "bike_stations" ("station_id", "station_name", "capacity", "location") VALUES
  (1, 'Station A', 20, '123 Main St'),
  (2, 'Station B', 15, '456 Oak St'),
  (3, 'Station B', 10, '456 Oak St');
  

-- StationReviews
INSERT INTO "station_reviews" ("id", "user_id", "station_id", "content", "date") VALUES
  (1, 5, 1, 'Memnunum!', '2023-01-22 09:45:00'),
  (2, 2, 3, 'Beğenmedim', '2022-06-05 11:20:00'),
  (3, 5, 2, 'Bir öncekinden daha kullanışlıydı', '2023-11-03 09:25:00');
  

-- Promotions
INSERT INTO "promotions" ("promotion_id", "name", "discount") VALUES
  (1, 'İlkbahar indirimi', 10),
  (2, 'Premium kullanıcılara özel', 30),
  (3, 'Yılbaşı indirimi', 20);


-- PremiumUsers
INSERT INTO "premium_users" ("user_id", "promotion_id", "pre_level") VALUES
  (2, 2, 'Gold'),
  (3, 2, 'Silver'),
  (5, 3, 'Silver');
  

-- RequestType
INSERT INTO "request_type" ("type_id", "type") VALUES
  (1, 'Uygulama Geliştirme'),
  (2, 'Bisikletlerle ilgili sorunlar'),
  (3, 'İstasyonlarla ilgili sorunlar'),
  (4, 'Üyelikle ilgili sorunlar');
  
  

-- UserRequests
INSERT INTO "user_requests" ("id", "user_id", "type_id", "explanation") VALUES
  (1, 1, 2, 'Bisikletin bakıma ihtiyacı var!'),
  (2, 3, 4, 'Üyelik ödememi yaptım ancak premium gözükmüyorum.'),
  (3, 5, 3, 'Kadıköy istasyonunda bisiklet yok.');
  

-- Bikes
INSERT INTO "bikes" ("bike_id", "station_id", "bike_type_id", "status") VALUES
  (1, 1, 1, 'Kullanılabilir'),
  (2, 1, 2, 'Kullanımda'),
  (3, 3, 2, 'Kullanılamaz'),
  (4, 2, 1, 'Kullanılabilir'),
  (5, 2, 1, 'Kullanımda');
  
  

-- Rentals
INSERT INTO "rentals" ("rental_id", "user_id", "bike_id", "start_time", "end_time", "total_cost", "date", "is_over") VALUES
  (1, 1, 1, '08:30:00', '10:30:00', 15.60, '2023-01-25', TRUE),
  (2, 2, 2, '14:00:00', '15:30:00', 12.50, '2023-01-02', TRUE);
  
  INSERT INTO "rentals" ("rental_id", "user_id", "bike_id", "start_time", "end_time", "date", "is_over") VALUES
  (6, 2, 1, '11:00:00', '12:30:00', '2023-01-07', FALSE);
  

-- RegularUsers
INSERT INTO "regular_users" ("user_id", "regular_level") VALUES
  (1, 'Level 1'),
  (4, 'Level 3'),
  (6, 'Level 3');
  

-- MaintenanceHistory
INSERT INTO "maintenance_history" ("id", "bike_id", "m_type", "m_date") VALUES
  (1, 1, 'Onarım', '2023-05-27'),
  (2, 2, 'Tekerlek değişimi', '2023-03-05');
  
--BSStatusHistory
INSERT INTO "bs_status_history" ("id", "status_id", "station_id", "date_and_time") VALUES
  (1, 1, 3, '2022-09-15 11:20:00'),
  (2, 2, 1, '2022-11-11 04:50:00'),
  (3, 2, 2, '2023-12-01 07:50:00');

--1.Fonksiyon-- ID' si girilen kullanıcının kiralama geçmişini getirir
CREATE OR REPLACE FUNCTION get_user_rentals(p_user_id INTEGER)
RETURNS TABLE (
    rental_id INTEGER,
    user_id INTEGER,
    bike_id INTEGER,
    start_time TIME,
    end_time TIME,
    total_cost MONEY,
    date DATE,
    is_over BOOLEAN,
    bike_type_id INTEGER,
    status VARCHAR(20)
) AS $$
BEGIN
    RETURN QUERY
    SELECT
        rentals.rental_id,
        rentals.user_id AS rental_user_id,
        rentals.bike_id,
        rentals.start_time,
        rentals.end_time,
        rentals.total_cost,
        rentals.date,
        rentals.is_over,
        bikes.bike_type_id,
        bikes.status
    FROM
        users
    JOIN rentals ON users.user_id = rentals.user_id
    JOIN bikes ON rentals.bike_id = bikes.bike_id
    WHERE
        users.user_id = get_user_rentals.p_user_id;
END;
$$ LANGUAGE plpgsql;
-----
SELECT * FROM get_user_rentals(1);
-------------------------------

--2.Fonksiyon-- Point değişkenine göre uygulamanın ortalama puanını getirir
CREATE OR REPLACE FUNCTION get_application_rating()
RETURNS DECIMAL AS $$
DECLARE
    total_points DECIMAL;
    total_users INTEGER;
    average_rating DECIMAL;
BEGIN
    -- Calculate total points and total users
    SELECT COALESCE(SUM(point::numeric), 0), COUNT(*) INTO total_points, total_users FROM user_ratings;

    -- Calculate average rating
    IF total_users > 0 THEN
        average_rating := total_points / total_users;
    ELSE
        average_rating := 0; -- Avoid division by zero
    END IF;

    -- Return the calculated average rating
    RETURN average_rating;
END;
$$ LANGUAGE plpgsql;
--------------------------------

SELECT get_application_rating();

--------------------------------

--3.Fonksiyon-- Tüm bisikletlerin bakım geçmişini bisikletler tablosuyla inner join yaparak getirir
CREATE OR REPLACE FUNCTION get_bike_maintenance_history()
RETURNS TABLE (
    bike_id INTEGER,
    bike_type_name VARCHAR(30),
    maintenance_id INTEGER,
    maintenance_type VARCHAR(50),
    maintenance_date DATE
) AS $$
BEGIN
    RETURN QUERY
    SELECT
        b.bike_id,
        bt.type_name AS bike_type_name,
        mh.id AS maintenance_id,
        mh.m_type AS maintenance_type,
        mh.m_date AS maintenance_date
    FROM
        bikes b
    JOIN
        maintenance_history mh ON b.bike_id = mh.bike_id
    JOIN
        bike_types bt ON b.bike_type_id = bt.id;
END;
$$ LANGUAGE plpgsql;
--------------------------------
SELECT * FROM get_bike_maintenance_history();
--------------------------------


--4.Fonksiyon-- ID'si girilen istasyonun bilgilerini istasyon durumları tablosuyla inner join yaparak getirir
CREATE OR REPLACE FUNCTION get_station_info(station_id_param INTEGER)
RETURNS TABLE (
    station_name VARCHAR(70),
    location VARCHAR,
    status_name VARCHAR(40),
    content VARCHAR(50),
    review_date TIMESTAMP
) AS $$
BEGIN
    RETURN QUERY
    SELECT
        bs.station_name,
        bs.location,
        bss.status_name,
        sr.content,
        sr.date AS review_date
    FROM
        bike_stations bs
    LEFT JOIN
        station_reviews sr ON bs.station_id = sr.station_id
    LEFT JOIN
        bs_status_history bssh ON bs.station_id = bssh.station_id
    LEFT JOIN
        bs_status bss ON bssh.status_id = bss.status_id
    WHERE
        bs.station_id = station_id_param;
END;
$$ LANGUAGE plpgsql;
---------------------------------
SELECT * FROM get_station_info(1);
---------------------------------


--5.fonksiyon--Id'si girilen kullanıcının kart bilgilerini getirir
CREATE OR REPLACE FUNCTION get_user_payment_info(user_id_param INTEGER)
RETURNS TABLE (
    card_id INTEGER,
    card_no VARCHAR(16),
    skt VARCHAR,
    cvc VARCHAR(3)
) AS $$
BEGIN
    RETURN QUERY
    SELECT
        pi.id AS card_id,
        pi.card_no,
        pi.skt,
        pi.cvc
    FROM
        payment_info pi
    WHERE
        pi.user_id = user_id_param;
END;
$$ LANGUAGE plpgsql;
---------------------------------------
SELECT * FROM get_user_payment_info(2);
---------------------------------------


--1.trigger-- Eğer kiralama işleminin fiyatı girilmediyse dakikasına göre fiyatı kendi hesaplar
-----
-----
CREATE OR REPLACE FUNCTION calculate_rental_cost()
RETURNS TRIGGER AS $$
DECLARE
    rental_duration interval;
BEGIN
    -- Eğer total_cost değeri boş ise
    IF NEW.total_cost IS NULL THEN
        -- Kiralama süresini hesapla
        rental_duration := NEW.end_time - NEW.start_time;

        -- Kiralama süresini dakika cinsinden al ve ücreti hesapla
        NEW.total_cost := EXTRACT(MINUTE FROM rental_duration);
        
        -- Dakikaları 1 TL ile çarp
        NEW.total_cost := NEW.total_cost * 1;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER calculate_rental_cost_trigger
BEFORE INSERT ON rentals
FOR EACH ROW
EXECUTE FUNCTION calculate_rental_cost();


--2.Trigger--Kullanıcı tablosuna bir kullanıcı eklenirken regular ya da premium olmasına göre kalıtım alınan tablolara gönderilir
--Yani eğer premium kullanıcı oluşturulduysa bilgileri premium_users tablosuna gönderilir
-- Trigger fonksiyonu oluşturulur
CREATE OR REPLACE FUNCTION assign_user_to_user_type_table()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.user_type = 'Regular' THEN
        --Regular ise regular_users tablosuna bilgileri ekler
        INSERT INTO regular_users (user_id, regular_level) VALUES (NEW.user_id, DEFAULT);
        --Premium ise premium_users tablosuna bilgileri ekler
    ELSIF NEW.user_type = 'Premium' THEN
        INSERT INTO premium_users (user_id, promotion_id, pre_level) VALUES (NEW.user_id, DEFAULT, DEFAULT);
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER assign_user_to_user_type_trigger
AFTER INSERT ON users
FOR EACH ROW
EXECUTE FUNCTION assign_user_to_user_type_table();
-------------------------------

--3.Trigger-- Kullanıcı tablosuna ad soyad girildiğinde ilk harfleri küçük ise büyük yapar
CREATE OR REPLACE FUNCTION capitalize_name()
RETURNS TRIGGER AS $$
BEGIN
    -- bir kullanıcı eklenilir ise
    IF TG_OP = 'INSERT' THEN
        -- Ad ve soyadı büyük harfe çevirir
        NEW.first_name := INITCAP(NEW.first_name);
        NEW.last_name := INITCAP(NEW.last_name);
    END IF;

    -- Güncellemede de aynısını yapar
    IF TG_OP = 'UPDATE' THEN
        IF NEW.first_name IS DISTINCT FROM OLD.first_name THEN
            NEW.first_name := INITCAP(NEW.first_name);
        END IF;

        IF NEW.last_name IS DISTINCT FROM OLD.last_name THEN
            NEW.last_name := INITCAP(NEW.last_name);
        END IF;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER capitalize_name_trigger
BEFORE INSERT OR UPDATE ON users
FOR EACH ROW
EXECUTE FUNCTION capitalize_name();

------------------------------------
--4.trigger-- Kiralama işlemlerindeki is_over değerinin değişmesine göre bisikletin durumunu değiştirir

CREATE OR REPLACE FUNCTION update_bike_status_on_rental_change()
RETURNS TRIGGER AS $$
BEGIN
    IF OLD.is_over IS DISTINCT FROM NEW.is_over THEN
        -- Eğer is_over değiştiyse
        IF NEW.is_over THEN
            -- Eğer is_over true olduysa bisiklet kullanılabilir hale gelir
            UPDATE bikes
            SET status = 'Kullanılabilir'
            WHERE bike_id = NEW.bike_id;
        ELSE
            -- Eğer is_over false olduysa bisiklet kullanılamaz hale gelir
            UPDATE bikes
            SET status = 'Kullanılamaz'
            WHERE bike_id = NEW.bike_id;
        END IF;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER update_bike_status_trigger
AFTER UPDATE ON rentals
FOR EACH ROW
EXECUTE FUNCTION update_bike_status_on_rental_change();
-------


----




DROP SCHEMA "public";
DROP DATABASE "Bisiklet_Paylasim_Sistemi";